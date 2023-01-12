using CsvHelper;
using CsvHelper.Configuration;
using Mega.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mega
{
    /// <summary>
    /// Логика взаимодействия для KadrWindow.xaml
    /// </summary>
    public partial class KadrWindow : Window
    {
        List<Employees> data = new List<Employees>();
        Employees selectedEmployer;
        public KadrWindow()
        {
            InitializeComponent();
            var req = new RestRequest("/getEmployees", Method.Get);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res = Helper.client.Get(req);
            data = JsonConvert.DeserializeObject<List<Employees>>(res.Content);
            if(ModelsRepository.EmployeesList.Count==0)
                foreach (Employees empoyer in data)
                {
                    ModelsRepository.EmployeesList.Add(empoyer);
                }
            EmployeesGrid.ItemsSource = ModelsRepository.EmployeesList;
            ModelsRepository.EmployeesList.ListChanged += _employes_CollectionChanged;
        }
        private void _employes_CollectionChanged(object sender, ListChangedEventArgs e)
        {

            if (EmployeesGrid.SelectedValue == null) return;

            Employees employe = (Employees)EmployeesGrid.SelectedItem;
            var req = new RestRequest("/updateEmploye", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("id_employer", employe.ID_Employees);
            req.AddParameter("middlename", employe.Surename);
            req.AddParameter("firstname", employe.Name);
            req.AddParameter("lasttname", employe.LastName);
            req.AddParameter("passportNumber", employe.PasportNumber);
            req.AddParameter("passportSiries", employe.PasportSiries);
            req.AddParameter("position", employe.Position);
            req.AddParameter("salary", employe.Salary);
            req.AddParameter("snils", employe.Snils);
            var res = Helper.client.Post(req);
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.DefaultExt = "csv";
                //saveFileDialog.GetType
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                if (saveFileDialog.ShowDialog() == true)
                    using (var writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {

                        var csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("ru-RU"))
                        {
                            Delimiter = ";",
                            HasHeaderRecord = false,
                        };
                        using (var csv = new CsvWriter(writer, csvConfig))
                        {
                            csv.WriteField("ID");
                            csv.WriteField("Отчество");
                            csv.WriteField("Имя");
                            csv.WriteField("Фамилия");
                            csv.WriteField("Серия паспорта");
                            csv.WriteField("Номер паспорта");
                            csv.WriteField("СНИЛС");
                            csv.WriteField("Должность");
                            csv.WriteField("Оклад");
                            csv.WriteField("Почта");
                            csv.NextRecord();
                            csv.WriteRecords(ModelsRepository.EmployeesList);
                        }
                        MessageBox.Show("Данные о сотрудниках успешно экспортированы");
                        return;
                    }
                MessageBox.Show("Экспорт отменен");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, возможно файл уже используется другим процессом");
            }
        }

        private void EmployeesGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && selectedEmployer!=null)
            {
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show("Вы хотите удалить сотрудника, это приведет к удалению\n всех связанных с ним данных.\n Продолжить?", "Предупреждение", button, icon, MessageBoxResult.Yes);
                if (result == MessageBoxResult.Yes)
                {
                    var reqDeleteEmployer = new RestRequest("/removeEployer", Method.Post);
                    reqDeleteEmployer.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    reqDeleteEmployer.AddParameter("id", selectedEmployer.ID_Employees);
                    var resDeleteEmployer = Helper.client.Post(reqDeleteEmployer);
                }
                else
                {
                    // _employers.AddNew();
                    ModelsRepository.EmployeesList.Add(selectedEmployer);
                    return;
                }

            }
        }

        private void EmployeesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesGrid.SelectedItem != null) selectedEmployer = (Employees)EmployeesGrid.SelectedItem;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Window w = new EmployerCreate();
            w.Show();
            this.Hide();
        }
    }
}
