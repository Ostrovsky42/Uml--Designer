
namespace UMLDisigner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.button_ArrowAssociation = new System.Windows.Forms.Button();
            this.button_ArrowInheritance = new System.Windows.Forms.Button();
            this.button_ArrowAggregation = new System.Windows.Forms.Button();
            this.button_ArrowImplementation = new System.Windows.Forms.Button();
            this.button_ArrowAddiction = new System.Windows.Forms.Button();
            this.button_StepBack = new System.Windows.Forms.Button();
            this.button_RectangleStack = new System.Windows.Forms.Button();
            this.button_ArrowAggregationPlus = new System.Windows.Forms.Button();
            this.button_ArrowСomposition = new System.Windows.Forms.Button();
            this.button_ArrowСompositionPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 586);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button_Clear
            // 
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Location = new System.Drawing.Point(967, 12);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(133, 29);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "CLear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Rectangle.Location = new System.Drawing.Point(967, 47);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(133, 27);
            this.button_Rectangle.TabIndex = 2;
            this.button_Rectangle.Text = "Rectangle";
            this.button_Rectangle.UseVisualStyleBackColor = true;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // button_ArrowAssociation
            // 
            this.button_ArrowAssociation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowAssociation.Location = new System.Drawing.Point(967, 113);
            this.button_ArrowAssociation.Name = "button_ArrowAssociation";
            this.button_ArrowAssociation.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowAssociation.TabIndex = 3;
            this.button_ArrowAssociation.Text = "ArrowAssociation";
            this.button_ArrowAssociation.UseVisualStyleBackColor = true;
            this.button_ArrowAssociation.Click += new System.EventHandler(this.button_ArrowAssociation_Click);
            // 
            // button_ArrowInheritance
            // 
            this.button_ArrowInheritance.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowInheritance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowInheritance.Location = new System.Drawing.Point(967, 146);
            this.button_ArrowInheritance.Name = "button_ArrowInheritance";
            this.button_ArrowInheritance.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowInheritance.TabIndex = 4;
            this.button_ArrowInheritance.Text = "ArrowInheritance";
            this.button_ArrowInheritance.UseVisualStyleBackColor = true;
            this.button_ArrowInheritance.Click += new System.EventHandler(this.button_ArrowInheritance_Click);
            // 
            // button_ArrowAggregation
            // 
            this.button_ArrowAggregation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowAggregation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowAggregation.Location = new System.Drawing.Point(967, 243);
            this.button_ArrowAggregation.Name = "button_ArrowAggregation";
            this.button_ArrowAggregation.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowAggregation.TabIndex = 5;
            this.button_ArrowAggregation.Text = "ArrowAggregation";
            this.button_ArrowAggregation.UseVisualStyleBackColor = true;
            this.button_ArrowAggregation.Click += new System.EventHandler(this.button_ArrowAggregation_Click);
            // 
            // button_ArrowImplementation
            // 
            this.button_ArrowImplementation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowImplementation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowImplementation.Location = new System.Drawing.Point(967, 211);
            this.button_ArrowImplementation.Name = "button_ArrowImplementation";
            this.button_ArrowImplementation.Size = new System.Drawing.Size(133, 26);
            this.button_ArrowImplementation.TabIndex = 7;
            this.button_ArrowImplementation.Text = "ArrowImplementation";
            this.button_ArrowImplementation.UseVisualStyleBackColor = true;
            this.button_ArrowImplementation.Click += new System.EventHandler(this.button_ArrowImplementation_Click);
            // 
            // button_ArrowAddiction
            // 
            this.button_ArrowAddiction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowAddiction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowAddiction.Location = new System.Drawing.Point(967, 179);
            this.button_ArrowAddiction.Name = "button_ArrowAddiction";
            this.button_ArrowAddiction.Size = new System.Drawing.Size(133, 26);
            this.button_ArrowAddiction.TabIndex = 8;
            this.button_ArrowAddiction.Text = "ArrowAddiction";
            this.button_ArrowAddiction.UseVisualStyleBackColor = true;
            this.button_ArrowAddiction.Click += new System.EventHandler(this.button_ArrowAddiction_Click);
            // 
            // button_StepBack
            // 
            this.button_StepBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_StepBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_StepBack.Location = new System.Drawing.Point(967, 541);
            this.button_StepBack.Name = "button_StepBack";
            this.button_StepBack.Size = new System.Drawing.Size(133, 26);
            this.button_StepBack.TabIndex = 9;
            this.button_StepBack.Text = "Step back";
            this.button_StepBack.UseVisualStyleBackColor = true;
            this.button_StepBack.Click += new System.EventHandler(this.button_StepBack_Click);
            // 
            // button_RectangleStack
            // 
            this.button_RectangleStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RectangleStack.Location = new System.Drawing.Point(967, 80);
            this.button_RectangleStack.Name = "button_RectangleStack";
            this.button_RectangleStack.Size = new System.Drawing.Size(133, 27);
            this.button_RectangleStack.TabIndex = 10;
            this.button_RectangleStack.Text = "RectangleStack";
            this.button_RectangleStack.UseVisualStyleBackColor = true;
            this.button_RectangleStack.Click += new System.EventHandler(this.button_RectangleStak_Click);
            // 
            // button_ArrowAggregationPlus
            // 
            this.button_ArrowAggregationPlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowAggregationPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowAggregationPlus.Location = new System.Drawing.Point(967, 276);
            this.button_ArrowAggregationPlus.Name = "button_ArrowAggregationPlus";
            this.button_ArrowAggregationPlus.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowAggregationPlus.TabIndex = 11;
            this.button_ArrowAggregationPlus.Text = "ArrowAggregationPlus";
            this.button_ArrowAggregationPlus.UseVisualStyleBackColor = true;
            this.button_ArrowAggregationPlus.Click += new System.EventHandler(this.button1_button_ArrowAggregationPlus_Click);
            // 
            // button_ArrowСomposition
            // 
            this.button_ArrowСomposition.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowСomposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowСomposition.Location = new System.Drawing.Point(967, 309);
            this.button_ArrowСomposition.Name = "button_ArrowСomposition";
            this.button_ArrowСomposition.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowСomposition.TabIndex = 12;
            this.button_ArrowСomposition.Text = "ArrowСomposition";
            this.button_ArrowСomposition.UseVisualStyleBackColor = true;
            this.button_ArrowСomposition.Click += new System.EventHandler(this.button_ArrowСomposition_Click);
            // 
            // button_ArrowСompositionPlus
            // 
            this.button_ArrowСompositionPlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_ArrowСompositionPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ArrowСompositionPlus.Location = new System.Drawing.Point(967, 342);
            this.button_ArrowСompositionPlus.Name = "button_ArrowСompositionPlus";
            this.button_ArrowСompositionPlus.Size = new System.Drawing.Size(133, 27);
            this.button_ArrowСompositionPlus.TabIndex = 13;
            this.button_ArrowСompositionPlus.Text = "ArrowСompositionPlus";
            this.button_ArrowСompositionPlus.UseVisualStyleBackColor = true;
            this.button_ArrowСompositionPlus.Click += new System.EventHandler(this.button_ArrowСompositionPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 610);
            this.Controls.Add(this.button_ArrowСompositionPlus);
            this.Controls.Add(this.button_ArrowСomposition);
            this.Controls.Add(this.button_ArrowAggregationPlus);
            this.Controls.Add(this.button_RectangleStack);
            this.Controls.Add(this.button_StepBack);
            this.Controls.Add(this.button_ArrowAddiction);
            this.Controls.Add(this.button_ArrowImplementation);
            this.Controls.Add(this.button_ArrowAggregation);
            this.Controls.Add(this.button_ArrowInheritance);
            this.Controls.Add(this.button_ArrowAssociation);
            this.Controls.Add(this.button_Rectangle);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.Button button_ArrowAssociation;
        private System.Windows.Forms.Button button_ArrowInheritance;
        private System.Windows.Forms.Button button_ArrowAggregation;       
        private System.Windows.Forms.Button button_ArrowImplementation;
        private System.Windows.Forms.Button button_ArrowAddiction;
        private System.Windows.Forms.Button button_StepBack;
       
       
        private System.Windows.Forms.Button button_RectangleStack;
        private System.Windows.Forms.Button button_ArrowAggregationPlus;
        private System.Windows.Forms.Button button_ArrowСomposition;
        private System.Windows.Forms.Button button_ArrowСompositionPlus;
    }
}

