using System;
using System.Windows.Forms;

namespace Views
{
  public class Login : Form
  {
    private Exemplo exemplo;
    private Label lblEmail;
    private TextBox inpEmail;
    private Label lblSenha;
    private TextBox inpSenha;
    private Button bntLogin;
    private CheckBox cbxEsqueciSenha;
    public Login()
    {
      lblEmail = new Label();
      lblEmail.Text = "Email:";
      lblEmail.Location = new System.Drawing.Point(90, 75);

      inpEmail = new TextBox();
      inpEmail.Location = new System.Drawing.Point(90, lblEmail.Location.Y + 25);
      inpEmail.Name = "inpEmail";
      inpEmail.Size = new System.Drawing.Size(200, 25);

      lblSenha = new Label();
      lblSenha.Text = "Senha:";
      lblSenha.Location = new System.Drawing.Point(90, inpEmail.Location.Y + 35);

      inpSenha = new TextBox();
      inpSenha.Location = new System.Drawing.Point(90, lblSenha.Location.Y + 25);
      inpSenha.Name = "inpSenha";
      inpSenha.Size = new System.Drawing.Size(200, 25);

      cbxEsqueciSenha = new CheckBox();
      cbxEsqueciSenha.Location = new System.Drawing.Point(90, inpSenha.Location.Y + 35);
      cbxEsqueciSenha.Name = "cbxEsqueciSenha";
      cbxEsqueciSenha.Text = "Esqueci minha senha";
      cbxEsqueciSenha.Size = new System.Drawing.Size(200, 25);

      bntLogin = new Button();
      bntLogin.Text = "Entrar";
      /* bntLogin.Size = new System.Drawing.Size(100, 100); */
      bntLogin.Location = new System.Drawing.Point(150, cbxEsqueciSenha.Location.Y + 55);
      bntLogin.Click += Logar;

      // Título da janela
      this.Text = "Login";

      // Tamanho da página
      this.Size = new System.Drawing.Size(400, 400);

      // Adicionando em tela
      Controls.Add(lblEmail);
      Controls.Add(inpEmail);
      Controls.Add(lblSenha);
      Controls.Add(inpSenha);
      Controls.Add(cbxEsqueciSenha);
      Controls.Add(bntLogin);
    }
    private void Logar(object sender, EventArgs e)
    {
      if (inpEmail.Text == "" && inpSenha.Text == "")
      {
        MessageBox.Show(
          "Preencha seu email e senha!",
          "Erro!",
          MessageBoxButtons.OK
        );
      }
      else if (inpEmail.Text == "")
      {
        MessageBox.Show(
          "Preencha seu email!",
          "Erro!",
          MessageBoxButtons.OK
        );
      }
      else if (inpSenha.Text == "")
      {
        MessageBox.Show(
          "Preencha sua senha!",
          "Erro!",
          MessageBoxButtons.OK
        );
      }
      else
      {
        MessageBox.Show(
          "Login realizado com sucesso!",
          "Logado!",
          MessageBoxButtons.OK
        );
        exemplo = new Exemplo(this);
        exemplo.Show();
        this.Hide();
      }
    }
  }
}