using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace laba19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            txtProcessor.Text = GetInfoString(GetHardwareInfo("Win32_Processor", "Name"));
            txtManufacturer.Text = GetInfoString(GetHardwareInfo("Win32_Processor", "Manufacturer"));
            txtDescription.Text = GetInfoString(GetHardwareInfo("Win32_Processor", "Description"));

            txtVideoCard.Text = GetInfoString(GetHardwareInfo("Win32_VideoController", "Name"));
            txtVideoProcessor.Text = GetInfoString(GetHardwareInfo("Win32_VideoController", "VideoProcessor"));
            txtDriverVersion.Text = GetInfoString(GetHardwareInfo("Win32_VideoController", "DriverVersion"));
            txtAdapterRAM.Text = GetInfoString(GetHardwareInfo("Win32_VideoController", "AdapterRAM"));

            txtDVDName.Text = GetInfoString(GetHardwareInfo("Win32_CDROMDrive", "Name"));
            txtDVDDrive.Text = GetInfoString(GetHardwareInfo("Win32_CDROMDrive", "Drive"));

            txtDiskDrive.Text = GetInfoString(GetHardwareInfo("Win32_DiskDrive", "Caption"));
            txtDiskSize.Text = GetInfoString(GetHardwareInfo("Win32_DiskDrive", "Size"));

            txtMotherboard.Text = GetInfoString(GetHardwareInfo("Win32_BaseBoard", "Product"));
            txtNetworkAdapter.Text = GetInfoString(GetHardwareInfo("Win32_BIOS", "Version"));
            txtBIOS.Text = GetInfoString(GetHardwareInfo("Win32_NetworkAdapter", "Name"));
        }

        private List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField]?.ToString().Trim() ?? "відсутній");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private string GetInfoString(List<string> infoList)
        {
            return infoList.Count > 0 ? string.Join(", ", infoList) : "відсутній";
        }
    }
}
