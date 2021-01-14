using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    partial class MainWindow
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
            this.FractalPicture = new System.Windows.Forms.PictureBox();
            this.ButtonChooseFractal = new System.Windows.Forms.Button();
            this.radioButtonSet = new System.Windows.Forms.RadioButton();
            this.RadioButtonTree = new System.Windows.Forms.RadioButton();
            this.RadioButtonKoch = new System.Windows.Forms.RadioButton();
            this.RadioButtonCarpet = new System.Windows.Forms.RadioButton();
            this.RadioButtonTriagle = new System.Windows.Forms.RadioButton();
            this.LabelChooseFractal = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TrackBarRecSteps = new System.Windows.Forms.TrackBar();
            this.RecStepsLable = new System.Windows.Forms.Label();
            this.LabelChooseRecSteps = new System.Windows.Forms.Label();
            this.PrintFractalButton = new System.Windows.Forms.Button();
            this.TextBoxAngle1 = new System.Windows.Forms.TextBox();
            this.TextBoxAngle2 = new System.Windows.Forms.TextBox();
            this.TextBoxTrees = new System.Windows.Forms.TextBox();
            this.LabelTrees = new System.Windows.Forms.Label();
            this.LabelAngles = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonColor1 = new System.Windows.Forms.Button();
            this.ButtonColor2 = new System.Windows.Forms.Button();
            this.PictureBoxColor2 = new System.Windows.Forms.PictureBox();
            this.PictureBoxColor1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRecSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor1)).BeginInit();
            this.SuspendLayout();
            // 
            // FractalPicture
            // 
            this.FractalPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FractalPicture.Location = new System.Drawing.Point(618, 12);
            this.FractalPicture.Name = "FractalPicture";
            this.FractalPicture.Size = new System.Drawing.Size(618, 563);
            this.FractalPicture.TabIndex = 0;
            this.FractalPicture.TabStop = false;
            this.FractalPicture.Visible = false;
            this.FractalPicture.SizeChanged += new System.EventHandler(this.FractalPicture_SizeChanged);
            // 
            // ButtonChooseFractal
            // 
            this.ButtonChooseFractal.BackColor = System.Drawing.Color.GreenYellow;
            this.ButtonChooseFractal.Location = new System.Drawing.Point(538, 408);
            this.ButtonChooseFractal.Name = "ButtonChooseFractal";
            this.ButtonChooseFractal.Size = new System.Drawing.Size(184, 47);
            this.ButtonChooseFractal.TabIndex = 1;
            this.ButtonChooseFractal.Text = "Выбрать фрактал";
            this.ButtonChooseFractal.UseVisualStyleBackColor = false;
            this.ButtonChooseFractal.Click += new System.EventHandler(this.ButtonPrintFractal_Click);
            // 
            // radioButtonSet
            // 
            this.radioButtonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSet.AutoSize = true;
            this.radioButtonSet.Font = new System.Drawing.Font("Segoe UI", 14.76522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSet.Location = new System.Drawing.Point(517, 350);
            this.radioButtonSet.Name = "radioButtonSet";
            this.radioButtonSet.Size = new System.Drawing.Size(258, 36);
            this.radioButtonSet.TabIndex = 1;
            this.radioButtonSet.Text = "Множество Кантора";
            this.radioButtonSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSet.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTree
            // 
            this.RadioButtonTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonTree.AutoSize = true;
            this.RadioButtonTree.Font = new System.Drawing.Font("Segoe UI", 14.76522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonTree.Location = new System.Drawing.Point(517, 184);
            this.RadioButtonTree.Name = "RadioButtonTree";
            this.RadioButtonTree.Size = new System.Drawing.Size(262, 36);
            this.RadioButtonTree.TabIndex = 1;
            this.RadioButtonTree.Text = "Фрактальное дерево";
            this.RadioButtonTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonTree.UseVisualStyleBackColor = true;
            // 
            // RadioButtonKoch
            // 
            this.RadioButtonKoch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonKoch.AutoSize = true;
            this.RadioButtonKoch.Checked = true;
            this.RadioButtonKoch.Font = new System.Drawing.Font("Segoe UI", 14.76522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonKoch.Location = new System.Drawing.Point(517, 130);
            this.RadioButtonKoch.Name = "RadioButtonKoch";
            this.RadioButtonKoch.Size = new System.Drawing.Size(169, 36);
            this.RadioButtonKoch.TabIndex = 1;
            this.RadioButtonKoch.TabStop = true;
            this.RadioButtonKoch.Text = "Кривая Коха";
            this.RadioButtonKoch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonKoch.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCarpet
            // 
            this.RadioButtonCarpet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonCarpet.AutoSize = true;
            this.RadioButtonCarpet.Font = new System.Drawing.Font("Segoe UI", 14.76522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonCarpet.Location = new System.Drawing.Point(517, 240);
            this.RadioButtonCarpet.Name = "RadioButtonCarpet";
            this.RadioButtonCarpet.Size = new System.Drawing.Size(251, 36);
            this.RadioButtonCarpet.TabIndex = 1;
            this.RadioButtonCarpet.Text = "Ковер Серпинского";
            this.RadioButtonCarpet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonCarpet.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTriagle
            // 
            this.RadioButtonTriagle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonTriagle.AutoSize = true;
            this.RadioButtonTriagle.Font = new System.Drawing.Font("Segoe UI", 14.76522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonTriagle.Location = new System.Drawing.Point(517, 292);
            this.RadioButtonTriagle.Name = "RadioButtonTriagle";
            this.RadioButtonTriagle.Size = new System.Drawing.Size(323, 36);
            this.RadioButtonTriagle.TabIndex = 1;
            this.RadioButtonTriagle.Text = "Треугольник Серпинского";
            this.RadioButtonTriagle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonTriagle.UseVisualStyleBackColor = true;
            // 
            // LabelChooseFractal
            // 
            this.LabelChooseFractal.AutoSize = true;
            this.LabelChooseFractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.76522F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelChooseFractal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelChooseFractal.Location = new System.Drawing.Point(260, 57);
            this.LabelChooseFractal.Name = "LabelChooseFractal";
            this.LabelChooseFractal.Size = new System.Drawing.Size(796, 31);
            this.LabelChooseFractal.TabIndex = 2;
            this.LabelChooseFractal.Text = "Пожалуйста, выберите один из предложенных фракталов";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(43, 57);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 34);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TrackBarRecSteps
            // 
            this.TrackBarRecSteps.Location = new System.Drawing.Point(34, 165);
            this.TrackBarRecSteps.Maximum = 20;
            this.TrackBarRecSteps.Minimum = 1;
            this.TrackBarRecSteps.Name = "TrackBarRecSteps";
            this.TrackBarRecSteps.Size = new System.Drawing.Size(303, 53);
            this.TrackBarRecSteps.TabIndex = 5;
            this.TrackBarRecSteps.Value = 1;
            this.TrackBarRecSteps.Visible = false;
            this.TrackBarRecSteps.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // RecStepsLable
            // 
            this.RecStepsLable.AutoSize = true;
            this.RecStepsLable.Location = new System.Drawing.Point(355, 184);
            this.RecStepsLable.Name = "RecStepsLable";
            this.RecStepsLable.Size = new System.Drawing.Size(17, 20);
            this.RecStepsLable.TabIndex = 6;
            this.RecStepsLable.Text = "1";
            this.RecStepsLable.Visible = false;
            // 
            // LabelChooseRecSteps
            // 
            this.LabelChooseRecSteps.AutoSize = true;
            this.LabelChooseRecSteps.Location = new System.Drawing.Point(34, 130);
            this.LabelChooseRecSteps.Name = "LabelChooseRecSteps";
            this.LabelChooseRecSteps.Size = new System.Drawing.Size(242, 20);
            this.LabelChooseRecSteps.TabIndex = 7;
            this.LabelChooseRecSteps.Text = "Выберете колличество итераций:";
            this.LabelChooseRecSteps.Visible = false;
            // 
            // PrintFractalButton
            // 
            this.PrintFractalButton.BackColor = System.Drawing.Color.GreenYellow;
            this.PrintFractalButton.Location = new System.Drawing.Point(34, 440);
            this.PrintFractalButton.Name = "PrintFractalButton";
            this.PrintFractalButton.Size = new System.Drawing.Size(167, 54);
            this.PrintFractalButton.TabIndex = 8;
            this.PrintFractalButton.Text = "Нарисовать фрактал";
            this.PrintFractalButton.UseVisualStyleBackColor = false;
            this.PrintFractalButton.Visible = false;
            this.PrintFractalButton.Click += new System.EventHandler(this.PrintFractalButton_Click);
            // 
            // TextBoxAngle1
            // 
            this.TextBoxAngle1.Location = new System.Drawing.Point(43, 263);
            this.TextBoxAngle1.Name = "TextBoxAngle1";
            this.TextBoxAngle1.Size = new System.Drawing.Size(120, 26);
            this.TextBoxAngle1.TabIndex = 9;
            this.TextBoxAngle1.Text = "30,2";
            this.TextBoxAngle1.Visible = false;
            // 
            // TextBoxAngle2
            // 
            this.TextBoxAngle2.Location = new System.Drawing.Point(252, 263);
            this.TextBoxAngle2.Name = "TextBoxAngle2";
            this.TextBoxAngle2.Size = new System.Drawing.Size(120, 26);
            this.TextBoxAngle2.TabIndex = 10;
            this.TextBoxAngle2.Text = "40,1";
            this.TextBoxAngle2.Visible = false;
            // 
            // TextBoxTrees
            // 
            this.TextBoxTrees.Location = new System.Drawing.Point(43, 329);
            this.TextBoxTrees.Name = "TextBoxTrees";
            this.TextBoxTrees.Size = new System.Drawing.Size(120, 26);
            this.TextBoxTrees.TabIndex = 11;
            this.TextBoxTrees.Text = "1,5";
            this.TextBoxTrees.Visible = false;
            // 
            // LabelTrees
            // 
            this.LabelTrees.AutoSize = true;
            this.LabelTrees.Location = new System.Drawing.Point(34, 292);
            this.LabelTrees.Name = "LabelTrees";
            this.LabelTrees.Size = new System.Drawing.Size(443, 20);
            this.LabelTrees.TabIndex = 7;
            this.LabelTrees.Text = "Выбрете отношение отрезков на соседних итерациях (1<n<3)";
            this.LabelTrees.Visible = false;
            // 
            // LabelAngles
            // 
            this.LabelAngles.AutoSize = true;
            this.LabelAngles.Location = new System.Drawing.Point(34, 221);
            this.LabelAngles.Name = "LabelAngles";
            this.LabelAngles.Size = new System.Drawing.Size(355, 20);
            this.LabelAngles.TabIndex = 7;
            this.LabelAngles.Text = "Введите угол наклона веток в градусах (0<n<=90)";
            this.LabelAngles.Visible = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.GreenYellow;
            this.ButtonSave.Location = new System.Drawing.Point(227, 441);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(162, 53);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Сохранить изображение";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ButtonColor1
            // 
            this.ButtonColor1.Location = new System.Drawing.Point(34, 361);
            this.ButtonColor1.Name = "ButtonColor1";
            this.ButtonColor1.Size = new System.Drawing.Size(147, 55);
            this.ButtonColor1.TabIndex = 13;
            this.ButtonColor1.Text = "Выбрать начальный цвет";
            this.ButtonColor1.UseVisualStyleBackColor = true;
            this.ButtonColor1.Visible = false;
            this.ButtonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // ButtonColor2
            // 
            this.ButtonColor2.Location = new System.Drawing.Point(242, 361);
            this.ButtonColor2.Name = "ButtonColor2";
            this.ButtonColor2.Size = new System.Drawing.Size(147, 55);
            this.ButtonColor2.TabIndex = 13;
            this.ButtonColor2.Text = "Выбрать конечный цвет";
            this.ButtonColor2.UseVisualStyleBackColor = true;
            this.ButtonColor2.Visible = false;
            this.ButtonColor2.Click += new System.EventHandler(this.ButtonColor2_Click);
            // 
            // PictureBoxColor2
            // 
            this.PictureBoxColor2.Location = new System.Drawing.Point(413, 377);
            this.PictureBoxColor2.Name = "PictureBoxColor2";
            this.PictureBoxColor2.Size = new System.Drawing.Size(31, 29);
            this.PictureBoxColor2.TabIndex = 14;
            this.PictureBoxColor2.TabStop = false;
            this.PictureBoxColor2.Visible = false;
            // 
            // PictureBoxColor1
            // 
            this.PictureBoxColor1.Location = new System.Drawing.Point(187, 377);
            this.PictureBoxColor1.Name = "PictureBoxColor1";
            this.PictureBoxColor1.Size = new System.Drawing.Size(31, 29);
            this.PictureBoxColor1.TabIndex = 14;
            this.PictureBoxColor1.TabStop = false;
            this.PictureBoxColor1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1263, 587);
            this.Controls.Add(this.PictureBoxColor1);
            this.Controls.Add(this.PictureBoxColor2);
            this.Controls.Add(this.ButtonColor2);
            this.Controls.Add(this.ButtonColor1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelAngles);
            this.Controls.Add(this.LabelTrees);
            this.Controls.Add(this.TextBoxTrees);
            this.Controls.Add(this.TextBoxAngle2);
            this.Controls.Add(this.TextBoxAngle1);
            this.Controls.Add(this.PrintFractalButton);
            this.Controls.Add(this.LabelChooseRecSteps);
            this.Controls.Add(this.RecStepsLable);
            this.Controls.Add(this.TrackBarRecSteps);
            this.Controls.Add(this.FractalPicture);
            this.Controls.Add(this.ButtonChooseFractal);
            this.Controls.Add(this.radioButtonSet);
            this.Controls.Add(this.RadioButtonKoch);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RadioButtonTriagle);
            this.Controls.Add(this.LabelChooseFractal);
            this.Controls.Add(this.RadioButtonCarpet);
            this.Controls.Add(this.RadioButtonTree);
            this.Name = "MainWindow";
            this.Text = "Фракталы";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.FractalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRecSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox FractalPicture;
        private Button ButtonChooseFractal;
        public RadioButton radioButtonSet;
        private RadioButton RadioButtonTree;
        private RadioButton RadioButtonKoch;
        private RadioButton RadioButtonCarpet;
        private RadioButton RadioButtonTriagle;
        private Label LabelChooseFractal;
        private Button BackButton;
        private TrackBar TrackBarRecSteps;
        private Label RecStepsLable;
        private Button PrintFractalButton;
        private Label LabelChooseRecSteps;
        private TextBox TextBoxAngle1;
        private TextBox TextBoxAngle2;
        private TextBox TextBoxTrees;
        private Label LabelTrees;
        private Label LabelAngles;
        private Button ButtonSave;
        private Button ButtonColor1;
        private Button ButtonColor2;
        private PictureBox PictureBoxColor2;
        private PictureBox PictureBoxColor1;
    }
}

