namespace Bank;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private void MoveLoginPage(object sender, EventArgs e)
    {
        if (txtName.Text != null || txtName.Text != null || txtSurname.Text != null || txtPhone.Text != null || txtLogin.Text != null || txtPassword.Text != null || txtConPassword.Text != null)
        {
            if (txtPassword.Text == txtConPassword.Text)
            {
                UserData user = new UserData()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Phone = txtPhone.Text,
                    Login = txtLogin.Text,
                    Password = txtPassword.Text
                };

                //userDatas.Add(user);

                this.Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("������", "������ �� ���������!", "��");
                return;
            }
        }
        else
        {
            DisplayAlert("������", "������� ��� ������!", "��");
            return;
        }
    }
}