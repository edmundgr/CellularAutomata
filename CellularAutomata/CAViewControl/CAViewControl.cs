using System.Drawing;
using CellularAutomataEngine;

namespace CAViewControl
{
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    public class CAViewControl : System.Windows.Forms.UserControl
   {
      private System.Windows.Forms.PictureBox CAPictureBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public CAViewControl()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();

         // TODO: Add any initialization after the InitForm call
         myCellSize = 1;
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if( components != null )
               components.Dispose();
         }
         base.Dispose( disposing );
      }

		#region Component Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.CAPictureBox = new System.Windows.Forms.PictureBox();
         this.SuspendLayout();
         // 
         // CAPictureBox
         // 
         this.CAPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.CAPictureBox.Name = "CAPictureBox";
         this.CAPictureBox.Size = new System.Drawing.Size(300, 350);
         this.CAPictureBox.TabIndex = 0;
         this.CAPictureBox.TabStop = false;
         // 
         // CAViewControl
         // 
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.CAPictureBox});
         this.Name = "CAViewControl";
         this.Size = new System.Drawing.Size(300, 350);
         this.Load += new System.EventHandler(this.CAViewControl_Load);
         this.ResumeLayout(false);

      }
		#endregion

      private CAEngine myCAEngine;

      public CAEngine Engine
      {
         get 
         {
            return myCAEngine;
         }
         set
         {
            myCAEngine = value;
         }
      }

      private int myCellSize;

      public int CellSize
      {
         get
         {
            return myCellSize;
         }
         set
         {
            myCellSize = value;
         }
      }

      private void DrawRow(DirectBitmap myBitmap, int row, int [] curRow)
      {
         int col = 0;
         int bmprow = 0;
         int bmpcol = 0;
         int bitmapRow = row * myCellSize;
         for (bmprow=bitmapRow; bmprow<bitmapRow+myCellSize; bmprow++)
         {
            for (col=0; col<curRow.Length; col++)
            {
               if (curRow[col] == 1)
                  for (bmpcol=col*myCellSize; bmpcol<col*myCellSize+myCellSize; bmpcol++)
                     myBitmap.SetPixel(bmpcol, bmprow, System.Drawing.Color.Black);
               else
                  for (bmpcol=col*myCellSize; bmpcol<col*myCellSize+myCellSize; bmpcol++)
                     myBitmap.SetPixel(bmpcol, bmprow, System.Drawing.Color.White);
            }
         }
      }

      public void Generate()
      {
         int[] curRow = new int[CAPictureBox.Size.Width/myCellSize];
         int col = 0;
         int row = 0;
         // create the first row(s)
         for (col=0; col<curRow.Length; col++)
            curRow[col] = 0;
         curRow[(int)(curRow.Length / 2)] = 1;
         myCAEngine.CurrentRow = curRow;

         var myBitmap = new DirectBitmap(CAPictureBox.Size.Width, CAPictureBox.Size.Height);

         DrawRow(myBitmap, 0, curRow);
         // draw a bitmap with the rows
         for (row=1; row<myBitmap.Size.Height/myCellSize; row++)
         {
            myCAEngine.GetNextRow().CopyTo(curRow, 0);
            DrawRow(myBitmap, row, curRow);
         }

         Bitmap oldBitmap = null;
         if (CAPictureBox.Image != null)
            oldBitmap = (Bitmap) CAPictureBox.Image;
         CAPictureBox.Image = myBitmap.Bitmap;
         if (oldBitmap != null)
            oldBitmap.Dispose();
      }

      private void CAViewControl_Load(object sender, System.EventArgs e)
      {
      }
   
	}
}
