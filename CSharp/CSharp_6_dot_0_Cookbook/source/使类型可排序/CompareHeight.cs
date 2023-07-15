namespace 使类型可排序
{
    public class CompareHeight : IComparer<Square>
    {
        public int Compare(object firstSquare, object secondSquare)
        {
            Square square1 = firstSquare as Square;
            Square square2 = firstSquare as Square;
            if (square1 == null || square2 == null)
                throw (new ArgumentException("Both parameters must be of type Square."));
            else
                return Compare(firstSquare, secondSquare);
        }

        #region IComparer<Square> Members

        public int Compare(Square x, Square y)
        {
            if (x.Height == y.Height)
                return 0;
            else if (x.Height > y.Height)
                return 1;
            else if (x.Height < y.Height)
                return -1;
            else
                return -1;
        }

        #endregion IComparer<Square> Members
    }
}