
namespace Calculadora_Daniel
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
            label1 = new Label();
            textOperador = new TextBox();
            textResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPunto = new Button();
            buttonBackDelete = new Button();
            buttonResultado = new Button();
            buttonMenos = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            buttonClear = new Button();
            buttonMOD = new Button();
            label2 = new Label();
            label3 = new Label();
            listHistorial = new ListBox();
            label4 = new Label();
            buttonElevado = new Button();
            buttonParentesisLeft = new Button();
            buttonParentesisRight = new Button();
            buttonClearHistorial = new Button();
            button10 = new Button();
            botonRaiz = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(127, 37);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DANIEL";
            // 
            // textOperador
            // 
            textOperador.BorderStyle = BorderStyle.FixedSingle;
            textOperador.Location = new Point(127, 93);
            textOperador.Name = "textOperador";
            textOperador.Size = new Size(227, 25);
            textOperador.TabIndex = 1;
            // 
            // textResultado
            // 
            textResultado.BorderStyle = BorderStyle.FixedSingle;
            textResultado.Location = new Point(127, 126);
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(227, 25);
            textResultado.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(24, 173);
            button1.Name = "button1";
            button1.Size = new Size(61, 26);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(91, 173);
            button2.Name = "button2";
            button2.Size = new Size(61, 26);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 173);
            button3.Name = "button3";
            button3.Size = new Size(61, 26);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 206);
            button4.Name = "button4";
            button4.Size = new Size(61, 26);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(91, 206);
            button5.Name = "button5";
            button5.Size = new Size(61, 26);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(159, 206);
            button6.Name = "button6";
            button6.Size = new Size(61, 26);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 239);
            button7.Name = "button7";
            button7.Size = new Size(61, 26);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(91, 239);
            button8.Name = "button8";
            button8.Size = new Size(61, 26);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(159, 239);
            button9.Name = "button9";
            button9.Size = new Size(61, 26);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(91, 272);
            button0.Name = "button0";
            button0.Size = new Size(61, 26);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button10_Click;
            // 
            // buttonPunto
            // 
            buttonPunto.Location = new Point(24, 272);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(61, 26);
            buttonPunto.TabIndex = 13;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = true;
            buttonPunto.Click += button11_Click;
            // 
            // buttonBackDelete
            // 
            buttonBackDelete.Location = new Point(159, 272);
            buttonBackDelete.Name = "buttonBackDelete";
            buttonBackDelete.Size = new Size(61, 26);
            buttonBackDelete.TabIndex = 14;
            buttonBackDelete.Text = "CE";
            buttonBackDelete.UseVisualStyleBackColor = true;
            buttonBackDelete.Click += button12_Click;
            // 
            // buttonResultado
            // 
            buttonResultado.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonResultado.Location = new Point(159, 309);
            buttonResultado.Name = "buttonResultado";
            buttonResultado.Size = new Size(195, 59);
            buttonResultado.TabIndex = 15;
            buttonResultado.Text = "=";
            buttonResultado.UseVisualStyleBackColor = true;
            buttonResultado.Click += button13_Click;
            // 
            // buttonMenos
            // 
            buttonMenos.Location = new Point(294, 173);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(61, 26);
            buttonMenos.TabIndex = 16;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = true;
            buttonMenos.Click += button14_Click;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(294, 206);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(61, 26);
            buttonMult.TabIndex = 17;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += button15_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(226, 206);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(61, 26);
            buttonDiv.TabIndex = 18;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += button16_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(226, 272);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(61, 26);
            buttonClear.TabIndex = 19;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button17_Click;
            // 
            // buttonMOD
            // 
            buttonMOD.Location = new Point(226, 239);
            buttonMOD.Name = "buttonMOD";
            buttonMOD.Size = new Size(61, 26);
            buttonMOD.TabIndex = 21;
            buttonMOD.Text = "MOD";
            buttonMOD.UseVisualStyleBackColor = true;
            buttonMOD.Click += button19_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 22;
            label2.Text = "OPERACIÓN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(24, 128);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 23;
            label3.Text = "RESULTADO";
            label3.Click += label3_Click;
            // 
            // listHistorial
            // 
            listHistorial.FormattingEnabled = true;
            listHistorial.ItemHeight = 17;
            listHistorial.Location = new Point(127, 385);
            listHistorial.Name = "listHistorial";
            listHistorial.Size = new Size(227, 72);
            listHistorial.TabIndex = 24;
            listHistorial.SelectedIndexChanged += listHistorial_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(24, 385);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 25;
            label4.Text = "HISTORIAL :";
            // 
            // buttonElevado
            // 
            buttonElevado.Location = new Point(294, 272);
            buttonElevado.Name = "buttonElevado";
            buttonElevado.Size = new Size(61, 26);
            buttonElevado.TabIndex = 27;
            buttonElevado.Text = "^";
            buttonElevado.UseVisualStyleBackColor = true;
            buttonElevado.Click += button20_Click;
            // 
            // buttonParentesisLeft
            // 
            buttonParentesisLeft.ImageAlign = ContentAlignment.MiddleRight;
            buttonParentesisLeft.Location = new Point(24, 309);
            buttonParentesisLeft.Name = "buttonParentesisLeft";
            buttonParentesisLeft.Size = new Size(61, 26);
            buttonParentesisLeft.TabIndex = 28;
            buttonParentesisLeft.Text = "(";
            buttonParentesisLeft.UseVisualStyleBackColor = true;
            buttonParentesisLeft.Click += button21_Click;
            // 
            // buttonParentesisRight
            // 
            buttonParentesisRight.ImageAlign = ContentAlignment.MiddleRight;
            buttonParentesisRight.Location = new Point(91, 309);
            buttonParentesisRight.Name = "buttonParentesisRight";
            buttonParentesisRight.Size = new Size(61, 26);
            buttonParentesisRight.TabIndex = 29;
            buttonParentesisRight.Text = ")";
            buttonParentesisRight.UseVisualStyleBackColor = true;
            buttonParentesisRight.Click += buttonParentesisRight_Click;
            // 
            // buttonClearHistorial
            // 
            buttonClearHistorial.Location = new Point(22, 419);
            buttonClearHistorial.Name = "buttonClearHistorial";
            buttonClearHistorial.Size = new Size(86, 39);
            buttonClearHistorial.TabIndex = 30;
            buttonClearHistorial.Text = "LIMPIAR ";
            buttonClearHistorial.UseVisualStyleBackColor = true;
            buttonClearHistorial.Click += buttonClearHistorial_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(226, 174);
            button10.Name = "button10";
            button10.Size = new Size(61, 25);
            button10.TabIndex = 32;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // botonRaiz
            // 
            botonRaiz.Location = new Point(293, 240);
            botonRaiz.Name = "botonRaiz";
            botonRaiz.Size = new Size(61, 26);
            botonRaiz.TabIndex = 33;
            botonRaiz.Text = "\t√";
            botonRaiz.UseVisualStyleBackColor = true;
            botonRaiz.Click += botonRaiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(381, 478);
            Controls.Add(botonRaiz);
            Controls.Add(button10);
            Controls.Add(buttonClearHistorial);
            Controls.Add(buttonParentesisRight);
            Controls.Add(buttonParentesisLeft);
            Controls.Add(buttonElevado);
            Controls.Add(label4);
            Controls.Add(listHistorial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonMOD);
            Controls.Add(buttonClear);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMult);
            Controls.Add(buttonMenos);
            Controls.Add(buttonResultado);
            Controls.Add(buttonBackDelete);
            Controls.Add(buttonPunto);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textResultado);
            Controls.Add(textOperador);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox textOperador;
        private TextBox textResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPunto;
        private Button buttonBackDelete;
        private Button buttonResultado;
        private Button buttonMenos;
        private Button buttonMult;
        private Button buttonDiv;
        private Button buttonClear;
        private Button buttonMOD;
        private Label label2;
        private Label label3;
        private ListBox listHistorial;
        private Label label4;
        private Button buttonElevado;
        private Button buttonParentesisLeft;
        private Button buttonParentesisRight;
        private Button buttonClearHistorial;
        private Button button10;
        private Button botonRaiz;
    }
}
