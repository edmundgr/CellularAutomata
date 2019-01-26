using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CellularAutomataEngine;

namespace CAWinApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CAForm : System.Windows.Forms.Form
	{
      private CellularAutomata.CAViewControl caViewControl1;
      private System.Windows.Forms.Button GenerateBT;
      private System.Windows.Forms.TextBox CANumberTB;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.HScrollBar CAhScroll;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.CheckBox CB7;
      private System.Windows.Forms.CheckBox CB6;
      private System.Windows.Forms.CheckBox CB5;
      private System.Windows.Forms.CheckBox CB4;
      private System.Windows.Forms.CheckBox CB3;
      private System.Windows.Forms.CheckBox CB2;
      private System.Windows.Forms.CheckBox CB1;
      private System.Windows.Forms.CheckBox CB0;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
      private System.Windows.Forms.TextBox cellSize;
      private System.Windows.Forms.Label label2;

      public const int CANumDefault = 110;

		public CAForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
         UpdateCACheckboxes(CANumDefault);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CAForm));
         this.caViewControl1 = new CellularAutomata.CAViewControl();
         this.GenerateBT = new System.Windows.Forms.Button();
         this.CANumberTB = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.CAhScroll = new System.Windows.Forms.HScrollBar();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.CB7 = new System.Windows.Forms.CheckBox();
         this.CB6 = new System.Windows.Forms.CheckBox();
         this.CB5 = new System.Windows.Forms.CheckBox();
         this.CB4 = new System.Windows.Forms.CheckBox();
         this.CB3 = new System.Windows.Forms.CheckBox();
         this.CB2 = new System.Windows.Forms.CheckBox();
         this.CB1 = new System.Windows.Forms.CheckBox();
         this.CB0 = new System.Windows.Forms.CheckBox();
         this.cellSize = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // caViewControl1
         // 
         this.caViewControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right);
         this.caViewControl1.CellSize = 1;
         this.caViewControl1.Engine = null;
         this.caViewControl1.Location = new System.Drawing.Point(8, 128);
         this.caViewControl1.Name = "caViewControl1";
         this.caViewControl1.Size = new System.Drawing.Size(300, 304);
         this.caViewControl1.TabIndex = 0;
         // 
         // GenerateBT
         // 
         this.GenerateBT.Location = new System.Drawing.Point(240, 16);
         this.GenerateBT.Name = "GenerateBT";
         this.GenerateBT.TabIndex = 6;
         this.GenerateBT.Text = "Generate";
         this.GenerateBT.Click += new System.EventHandler(this.GenerateBT_Click);
         // 
         // CANumberTB
         // 
         this.CANumberTB.Location = new System.Drawing.Point(88, 16);
         this.CANumberTB.Name = "CANumberTB";
         this.CANumberTB.Size = new System.Drawing.Size(32, 20);
         this.CANumberTB.TabIndex = 5;
         this.CANumberTB.Text = "110";
         this.CANumberTB.TextChanged += new System.EventHandler(this.CANumberTB_TextChanged);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(16, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 23);
         this.label1.TabIndex = 4;
         this.label1.Text = "CA Number:";
         // 
         // CAhScroll
         // 
         this.CAhScroll.Location = new System.Drawing.Point(8, 48);
         this.CAhScroll.Maximum = 253;
         this.CAhScroll.Minimum = 2;
         this.CAhScroll.Name = "CAhScroll";
         this.CAhScroll.Size = new System.Drawing.Size(304, 16);
         this.CAhScroll.TabIndex = 9;
         this.CAhScroll.Value = 110;
         this.CAhScroll.ValueChanged += new System.EventHandler(this.CAhScroll_ValueChanged);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(8, 80);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(304, 16);
         this.pictureBox1.TabIndex = 10;
         this.pictureBox1.TabStop = false;
         // 
         // CB7
         // 
         this.CB7.Location = new System.Drawing.Point(16, 96);
         this.CB7.Name = "CB7";
         this.CB7.Size = new System.Drawing.Size(16, 24);
         this.CB7.TabIndex = 11;
         this.CB7.CheckedChanged += new System.EventHandler(this.CB7_CheckedChanged);
         // 
         // CB6
         // 
         this.CB6.Location = new System.Drawing.Point(54, 96);
         this.CB6.Name = "CB6";
         this.CB6.Size = new System.Drawing.Size(16, 24);
         this.CB6.TabIndex = 12;
         this.CB6.CheckedChanged += new System.EventHandler(this.CB6_CheckedChanged);
         // 
         // CB5
         // 
         this.CB5.Location = new System.Drawing.Point(88, 96);
         this.CB5.Name = "CB5";
         this.CB5.Size = new System.Drawing.Size(16, 24);
         this.CB5.TabIndex = 13;
         this.CB5.CheckedChanged += new System.EventHandler(this.CB5_CheckedChanged);
         // 
         // CB4
         // 
         this.CB4.Location = new System.Drawing.Point(124, 96);
         this.CB4.Name = "CB4";
         this.CB4.Size = new System.Drawing.Size(16, 24);
         this.CB4.TabIndex = 14;
         this.CB4.CheckedChanged += new System.EventHandler(this.CB4_CheckedChanged);
         // 
         // CB3
         // 
         this.CB3.Location = new System.Drawing.Point(160, 96);
         this.CB3.Name = "CB3";
         this.CB3.Size = new System.Drawing.Size(16, 24);
         this.CB3.TabIndex = 15;
         this.CB3.CheckedChanged += new System.EventHandler(this.CB3_CheckedChanged);
         // 
         // CB2
         // 
         this.CB2.Location = new System.Drawing.Point(198, 96);
         this.CB2.Name = "CB2";
         this.CB2.Size = new System.Drawing.Size(16, 24);
         this.CB2.TabIndex = 16;
         this.CB2.CheckedChanged += new System.EventHandler(this.CB2_CheckedChanged);
         // 
         // CB1
         // 
         this.CB1.Location = new System.Drawing.Point(236, 96);
         this.CB1.Name = "CB1";
         this.CB1.Size = new System.Drawing.Size(16, 24);
         this.CB1.TabIndex = 17;
         this.CB1.CheckedChanged += new System.EventHandler(this.CB1_CheckedChanged);
         // 
         // CB0
         // 
         this.CB0.Location = new System.Drawing.Point(272, 96);
         this.CB0.Name = "CB0";
         this.CB0.Size = new System.Drawing.Size(16, 24);
         this.CB0.TabIndex = 18;
         this.CB0.CheckedChanged += new System.EventHandler(this.CB0_CheckedChanged);
         // 
         // cellSize
         // 
         this.cellSize.Location = new System.Drawing.Point(200, 16);
         this.cellSize.Name = "cellSize";
         this.cellSize.Size = new System.Drawing.Size(32, 20);
         this.cellSize.TabIndex = 20;
         this.cellSize.Text = "2";
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(136, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 23);
         this.label2.TabIndex = 19;
         this.label2.Text = "Cell Size:";
         // 
         // CAForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(320, 453);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.cellSize,
                                                                      this.label2,
                                                                      this.CB0,
                                                                      this.CB1,
                                                                      this.CB2,
                                                                      this.CB3,
                                                                      this.CB4,
                                                                      this.CB5,
                                                                      this.CB6,
                                                                      this.CB7,
                                                                      this.pictureBox1,
                                                                      this.CAhScroll,
                                                                      this.GenerateBT,
                                                                      this.CANumberTB,
                                                                      this.label1,
                                                                      this.caViewControl1});
         this.Name = "CAForm";
         this.Text = "Cellular Automata";
         this.Load += new System.EventHandler(this.CAForm_Load);
         this.ResumeLayout(false);

      }
		#endregion

      private CAEngine aCAEngine;

      private void GenerateBT_Click(object sender, System.EventArgs e)
      {
         // if we implement IDisposable we could dispose of the old CAEngine
         int CellSize = System.Convert.ToInt32(cellSize.Text);
         if (CellSize > this.caViewControl1.Width/2) CellSize = 1;
         aCAEngine = new CAEngine(this.caViewControl1.Width/CellSize);
         aCAEngine.RuleNumber = System.Convert.ToInt32(CANumberTB.Text);
         this.caViewControl1.Engine = aCAEngine;
         this.caViewControl1.CellSize = CellSize;
         this.caViewControl1.Generate();
      }
      
      /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CAForm());
		}

      private void CAForm_Load(object sender, System.EventArgs e)
      {
      }


      private void CANumberTB_TextChanged(object sender, System.EventArgs e)
      {
         int canum = System.Convert.ToInt32(CANumberTB.Text);
         if (canum >= CAhScroll.Minimum && canum <= CAhScroll.Maximum)
            CAhScroll.Value = canum;
         UpdateCACheckboxes(canum);
      }

      private void CAhScroll_ValueChanged(object sender, System.EventArgs e)
      {
         CANumberTB.Text = CAhScroll.Value.ToString();
         UpdateCACheckboxes(CAhScroll.Value);
      }

      public void UpdateCACheckboxes(int caNum)
      {
         CB0.Checked = (caNum & 1<<0) != 0;
         CB1.Checked = (caNum & 1<<1) != 0;
         CB2.Checked = (caNum & 1<<2) != 0;
         CB3.Checked = (caNum & 1<<3) != 0;
         CB4.Checked = (caNum & 1<<4) != 0;
         CB5.Checked = (caNum & 1<<5) != 0;
         CB6.Checked = (caNum & 1<<6) != 0;
         CB7.Checked = (caNum & 1<<7) != 0;
      }

      public int GetCheckboxCANum()
      {
         int canum = 0;
         if (CB0.Checked) canum |= 1<<0;
         if (CB1.Checked) canum |= 1<<1;
         if (CB2.Checked) canum |= 1<<2;
         if (CB3.Checked) canum |= 1<<3;
         if (CB4.Checked) canum |= 1<<4;
         if (CB5.Checked) canum |= 1<<5;
         if (CB6.Checked) canum |= 1<<6;
         if (CB7.Checked) canum |= 1<<7;
         return canum;
      }
         
      private void CB0_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB1_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB2_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB3_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB4_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB5_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB6_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }

      private void CB7_CheckedChanged(object sender, System.EventArgs e)
      {
         int canum = GetCheckboxCANum();
         CANumberTB.Text = canum.ToString();
      }


   }
}
