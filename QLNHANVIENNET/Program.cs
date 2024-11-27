
using System;
using System.IO;
using System.Windows.Forms;

namespace QLNHANVIENNET
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                using (StreamReader inp = new StreamReader("input.txt"))
                {
                    Console.SetIn(inp);
                    string tk = Console.ReadLine(); // Username
                    string mk = Console.ReadLine(); // Password
                    string loaitk = Console.ReadLine(); // User type

                    //MessageBox.Show($"Username: {tk}, Password: {mk}, User Type: {loaitk}");
                    if (!string.IsNullOrEmpty(tk) && !string.IsNullOrEmpty(mk))
                    {
                        if (loaitk == "ADMIN")
                        {
                            inp.Close();
                            // Open the main form if user type is "Quản Lý"
                            Application.Run(new frmmain(loaitk));
                        }
                        else
                        {
                            // Optionally handle other user types
                            //MessageBox.Show("User type not recognized.");
                            inp.Close();
                            Application.Run(new Form1());
                        }
                    }
                    else
                    {
                        // Show the login form if credentials are empty
                        MessageBox.Show("Username or password is empty.");
                        inp.Close();
                        Application.Run(new Form1());
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and show error message
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
        }
    }
}