using System;
using System.Windows.Forms;

namespace Views
{
  public class Exemplo : Form
  {
    private Form parent;
    private Label lblExemplo;
    private Button bntButton;
    private CheckBox cbxCheck;
    private TextBox inpInput;
    public Exemplo(Form parent)
    {
      this.parent = parent;

      lblExemplo = new Label();
      lblExemplo.Text = "Olá, mundo!";
      lblExemplo.Location = new System.Drawing.Point(50, 50);

      bntButton = new Button();
      bntButton.Text = "Clique aqui!";
      bntButton.Size = new System.Drawing.Size(100, 30);
      bntButton.Location = new System.Drawing.Point(50, 150);
      bntButton.Click += ClicarBotao;

      cbxCheck = new CheckBox();
      cbxCheck.Location = new System.Drawing.Point(50, 80);
      cbxCheck.Name = "cbxCheck";
      cbxCheck.Text = "Checkbox 1";

      inpInput = new TextBox();
      inpInput.Location = new System.Drawing.Point(50, 110);
      inpInput.Name = "inpInput";
      inpInput.Size = new System.Drawing.Size(200, 200);

      // Título da janela
      this.Text = "Minha primeira janela";

      // Tamanho da página
      this.Size = new System.Drawing.Size(400, 400);

      // Adicionando em tela
      Controls.Add(lblExemplo);
      Controls.Add(bntButton);
      Controls.Add(cbxCheck);
      Controls.Add(inpInput);

      FormClosed += AoFechar;
    }
    private void ClicarBotao(object sender, EventArgs e)
    {
      if (inpInput.Text != "")
      {
        lblExemplo.Text = inpInput.Text;
      }
      else
      {
        MessageBox.Show(
          "O input não pode ser vazio!",
          "Erro!",
          MessageBoxButtons.OK
        );
      }
    }

    private void AoFechar(object sender, FormClosedEventArgs e)
    {
      this.parent.Show();
    }
  }
}