using System.Collections;

namespace CellularAutomataEngine
{
    /// <summary>
    /// Summary description for CAEngine.
    /// </summary>
    public class CAEngine
    {
        int _ruleNumber;
        readonly int _rowLen;
        int[] _row;
        readonly int[] _nextRow;

        public CAEngine(int rowlen)
        {
            if (rowlen < 3) rowlen = 3;
            _ruleNumber = 110;
            _rowLen = rowlen;
            _row = new int[_rowLen];
            _nextRow = new int[_rowLen];
        }

        public int RowLength
        {
            get { return _rowLen; }
        }

        public int RuleNumber
        {
            get { return _ruleNumber; }
            set
            {
                _ruleNumber = IsValidRule(value) ? value : 110;
            }
        }

        public int[] CurrentRow
        {
            get { return _row; }
            set
            {
                if (value != null && value.Length == _rowLen)
                {
                    value.CopyTo(_row, 0);
                }

            }
        }

        private static bool IsValidRule(int value)
        {
            return value > 1 && value < 254;
        }

        private int ApplyRule(int num)    // Num is the binary representation of the three cells
        {
            int CellValue = 0;

            if (num >= 0 && num <= 7)
            {
                if ((_ruleNumber & (1 << num)) == 0)
                    CellValue = 0;
                else
                    CellValue = 1;
            }

            return (CellValue);
        }

        public int[] GetNextRow()
        {
            //int[] NextRow = new int[RowLen];

            _nextRow[0] = ApplyRule((_row[_rowLen - 1] << 2) + (_row[0] << 1) + _row[1]);
            for (int index = 1; index < _rowLen - 1; index++)
            {
                _nextRow[index] = ApplyRule((_row[index - 1] << 2) + (_row[index] << 1) + _row[index + 1]);
            }
            _nextRow[_rowLen - 1] = ApplyRule((_row[_rowLen - 2] << 2) + (_row[_rowLen - 1] << 1) + _row[0]);

            // copy the NextRow into the previous row
            _nextRow.CopyTo(_row, 0);
            return (_row);
        }
    }
}
