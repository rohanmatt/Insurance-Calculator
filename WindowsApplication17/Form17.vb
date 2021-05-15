Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Male")
        ListBox1.Items.Add("Female")
        ComboBox1.Items.Add("30 to <40")
        ComboBox1.Items.Add("40 to <50")
        ComboBox1.Items.Add("50 to <60")
        ComboBox1.Items.Add(">60")
        Label1.Text = Date.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "30 to <40" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 40K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "30 to <40" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 30K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "30 to <40" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 60K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "30 to <40" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 50K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "40 to <50" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 60K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "40 to <50" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 40K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "40 to <50" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 50K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "40 to <50" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 20K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "50 to <60" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 70K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = "50 to <60" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 50K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "50 to <60" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 40K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = "50 to <60" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 20K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = ">60" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 80K"
        ElseIf ListBox1.SelectedItem = "Male" And ComboBox1.SelectedItem = ">60" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Isurance is 40K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = ">60" And CheckBox1.Checked = "False" Then
            TextBox1.Text = "Insurance is 40K"
        ElseIf ListBox1.SelectedItem = "Female" And ComboBox1.SelectedItem = ">60" And CheckBox1.Checked = "True" Then
            TextBox1.Text = "Insurance is 40K"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class
