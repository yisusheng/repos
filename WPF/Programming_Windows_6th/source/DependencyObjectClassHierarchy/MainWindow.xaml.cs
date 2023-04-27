using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyObjectClassHierarchy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Type rootType = typeof(DependencyObject);
        private TypeInfo rootTypeInfo = typeof(DependencyObject).GetTypeInfo();
        private List<Type> classes = new List<Type>();

        public MainWindow()
        {
            InitializeComponent();
            AddToClassList(typeof(System.Windows.DependencyObject));
            classes.Sort((t1, t2) =>
            {
                return String.Compare(t1.GetTypeInfo().Name, t2.GetTypeInfo().Name);
            });
            var rootClass = new ClassAndSubclasses(rootType);
            AddToTree(rootClass, classes);
            Display(rootClass, 0);
        }

        private void AddToClassList(Type sampleType)
        {
            var assembly = sampleType.GetTypeInfo().Assembly;
            foreach (var type in assembly.ExportedTypes)
            {
                TypeInfo typeInfo = type.GetTypeInfo();
                if (typeInfo.IsPublic && rootTypeInfo.IsAssignableFrom(typeInfo))
                    classes.Add(type);
            }
        }

        private void AddToTree(ClassAndSubclasses parentClass, List<Type> classes)
        {
            foreach (var type in classes)
            {
                var baseType = type.GetTypeInfo().BaseType;

                if (baseType == parentClass.Type)
                {
                    var subClass = new ClassAndSubclasses(type);
                    parentClass.Subclasses.Add(subClass);
                    AddToTree(subClass, classes);
                }
            }
        }

        private void Display(ClassAndSubclasses parentClass, int indent)
        {
            var typeInfo = parentClass.Type.GetTypeInfo();

            TextBlock txtblk = new();
            txtblk.Inlines.Add(new Run { Text = new string(' ', 8 * indent) });
            txtblk.Inlines.Add(new Run { Text = typeInfo.Name });

            if (typeInfo.IsSealed)
                txtblk.Inlines.Add(new Run
                {
                    Text = " (sealed)"
                });

            IEnumerable<ConstructorInfo> constructorInfos = typeInfo.DeclaredConstructors;
            int publicConstructorCount = 0;

            foreach (var constructorInfo in constructorInfos)
            {
                if (constructorInfo.IsPublic)
                    publicConstructorCount += 1;
            }

            if (publicConstructorCount == 0)
                txtblk.Inlines.Add(new Run
                {
                    Text = " (non-instantiable)"
                });

            stackPanel.Children.Add(txtblk);

            foreach (var subclass in parentClass.Subclasses)
                Display(subclass, indent + 1);
        }
    }
}