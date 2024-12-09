using ElectronicDeviceManager.BusinessLayer.Concrete;
using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.DataAccessLayer.Repositories;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.DesktopUI.Forms
{
    public partial class DeviceForm : BaseForm
    {
        private DeviceRepository _deviceRepository;
        private DeviceService _deviceService;

        public DeviceForm()
        {
            var dbContext = new AppDbContext();
            InitializeComponent();
            _deviceRepository = new DeviceRepository(dbContext);
            _deviceService = new DeviceService(_deviceRepository);


        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            var typeList = new List<string> { "Telefon", "Tablet", "Bilgisayar", "Araba" };
            cmbType.DataSource = typeList;

            var stateList = new List<string> { "Aktif", "Pasif" };
            cmbState.DataSource = stateList;

            GetList();

        }

        protected override void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                string SerialNo = txtSerialNbr.Text;
                string Desc = txtDesc.Text;
                string selectedItem = cmbType.SelectedItem.ToString();
                string selectedState = cmbState.SelectedItem.ToString();

                bool isSelectedStateActive = (selectedState == "Aktif");
                //bu true veya false döner.



                Device device = new Device()
                {
                    DeviceName = Name,
                    SerialNumber = SerialNo,
                    DeviceDescription = Desc,
                    DeviceType = selectedItem,
                    IsActive = isSelectedStateActive,


                };
                _deviceRepository.Create(device);
                MessageBox.Show("Kayıt başarılı.");
                GetList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected override void btn_List_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void GetList()
        {
            lstListe.ValueMember = "Id";
            lstListe.DisplayMember = "DisplayInfo";
            lstListe.DataSource = _deviceRepository.GetAll();
            lstListe.SelectedIndex = -1;
            secilenItem = null;
        }

        protected override void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                _deviceService.Delete(secilenItem.Id);
                GetList();
                MessageBox.Show("Seçilen öğe başarıyla silindi.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        protected override void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenItem != null)
                {
                    
                    secilenItem.DeviceName = txtName.Text;
                    secilenItem.DeviceDescription = txtDesc.Text;
                    secilenItem.SerialNumber = txtSerialNbr.Text;
                    secilenItem.DeviceType = cmbType.Text;

                    string selectedState = cmbState.Text.ToString();
                    bool isSelectedStateActive = (selectedState == "Aktif");
                    secilenItem.IsActive = isSelectedStateActive;
                    _deviceRepository.Update(secilenItem);
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    GetList();
                }
                //Normaşde bu işlemin service de olması daha dğru olurdu. Yani null kontrellri burada olabilir ancak null ise serviceye atanabilir.
                else
                {
                    MessageBox.Show("Lütfen kullanım durumu seçiniz...");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Device? secilenItem;

        /* benden 45 dk çalan kod bloğum
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstListe.SelectedIndex != -1)
            {
                secilenItem = lstListe.SelectedItem as Device;
                if (secilenItem != null)
                {
                    txtName.Text = secilenItem.DeviceName;
                    txtSerialNbr.Text = secilenItem.SerialNumber;
                    cmbState.Text = secilenItem.IsActive ? "Aktif" : "Pasif";
                    txtDesc.Text = secilenItem.DeviceDescription;
                    cmbType.Text = secilenItem.DeviceType;

                }
            }
        }
        */

        private void lstListe_SelectedIndexChanged_1(object sender, EventArgs e)
        
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenItem = lstListe.SelectedItem as Device;
                if (secilenItem != null)
                {
                    txtName.Text = secilenItem.DeviceName;
                    txtSerialNbr.Text = secilenItem.SerialNumber;
                    cmbState.Text = secilenItem.IsActive ? "Aktif" : "Pasif";
                    txtDesc.Text = secilenItem.DeviceDescription;
                    cmbType.Text = secilenItem.DeviceType;

                }
            }
        }
    }

    internal class DeviceService
    {
        private DeviceRepository deviceRepository;

        public DeviceService(DeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }
    }
}
