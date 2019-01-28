using System;
using System.Collections;

namespace CellularAutomataEngine
{
    /// <summary>
    /// Summary description for CAEngine.
    /// </summary>
    public class CAEngine
    {
        private int _ruleNumber;
        private readonly int _rowLen;
        private int[] _row;
        private readonly int[] _nextRow;
        public const int DefaultRule = 30;

        public CAEngine(int rowlen)
        {
            if (rowlen < 3) rowlen = 3;
            _ruleNumber = DefaultRule;
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
                _ruleNumber = IsValidRule(value) ? value : Math.Max(0, Math.Min(255, value));
            }
        }

        public int[] CurrentRow
        {
            get { return _row; }
            set
            {
                if (value != null && value.Length == RowLength)
                {
                    value.CopyTo(_row, 0);
                }

            }
        }

        private static bool IsValidRule(int value)
        {
            return value >= 0 && value <= 255;
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

            _nextRow[0] = ApplyRule((CurrentRow[RowLength - 1] << 2) + (CurrentRow[0] << 1) + CurrentRow[1]);
            for (int index = 1; index < RowLength - 1; index++)
            {
                _nextRow[index] = ApplyRule((CurrentRow[index - 1] << 2) + (CurrentRow[index] << 1) + CurrentRow[index + 1]);
            }
            _nextRow[RowLength - 1] = ApplyRule((CurrentRow[RowLength - 2] << 2) + (CurrentRow[RowLength - 1] << 1) + CurrentRow[0]);

            // copy the NextRow into the previous row
            _nextRow.CopyTo(_row, 0);
            return (_row);
        }
    }
}
