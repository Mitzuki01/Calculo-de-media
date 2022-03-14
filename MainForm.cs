/*
 * Created by SharpDevelop.
 * User: user
 * Date: 11/03/2022
 * Time: 03:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace teste1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			float n1,n2,n3 , media;
			string aluno,gta;
			
			aluno= textBox1.Text;
			n1= float.Parse(textBox2.Text);
			n2= float.Parse(textBox3.Text);
			n3= float.Parse(textBox4.Text);
			media=(n1 + n2 + n3)/3;
			
			if(media >=5){
				gta ="Aprovado";
			
			}else
			{
				gta="Reprovado";
			};
			
			MessageBox.Show("Aluno :" + aluno + "\n" + "Media :" + media + "\n" + "Resultado :" + gta);
		
		}
	}
}
