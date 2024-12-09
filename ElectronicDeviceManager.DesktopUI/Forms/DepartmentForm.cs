using ElectronicDeviceManager.BusinessLayer.Concrete;
using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.DataAccessLayer.Repositories;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.DesktopUI.Forms
{
    public partial class DepartmentForm : BaseForm
    {
        private DepartmentRepository _departmentRepo;
        private DepartmentService _departmentService;
        public DepartmentForm()
        {
            secilenItem = null;
            var dbCoontext = new AppDbContext();
            InitializeComponent();
            _departmentRepo = new DepartmentRepository(dbCoontext);
            _departmentService = new DepartmentService(_departmentRepo);

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            var stateList = new List<string> { "Aktif", "Pasif" };
            cmbState.DataSource = stateList; 
            GetList();
        }
        Department secilenItem;
        private void GetList()
        {
            lstList.ValueMember = "Id";
            lstList.DisplayMember = "DisplayInfo";
            lstList.DataSource = _departmentRepo.GetAll();
            lstList.SelectedIndex = -1;
            secilenItem = null;
        }

        protected override void btn_Save_Click(object sender, EventArgs e)
        {
            string cName = txtCName.Text;
            string cDesc = txtCDesc.Text;
            string selectedState = cmbState.SelectedItem.ToString();
            bool isSelectedStateActive = (selectedState == "Aktif");

            Department department = new Department()
            {
                CreatedDate = DateTime.Now,
                Name = cName,
                Description = cDesc,
                IsActive = isSelectedStateActive,
            };
            _departmentRepo.Create(department);
            MessageBox.Show($"{selectedState} kategori oluşlturuldu.");
            GetList();
        }
        protected override void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                _departmentService.Delete(secilenItem.Id);
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
            secilenItem.Name = txtCName.Text;
            secilenItem.Description = txtCDesc.Text;
            string selectedState = cmbState.SelectedItem.ToString();
            bool isSelectedStateActive = (selectedState == "Aktif");
            secilenItem.IsActive = isSelectedStateActive;

            _departmentRepo.Update(secilenItem);
            MessageBox.Show("Seçilen öğe başarıyla güncellendi.");
            GetList();
        }
        protected override void btn_List_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex != -1)
            {
                secilenItem = lstList.SelectedItem as Department;
                if (secilenItem != null)
                {
                    txtCName.Text = secilenItem.Name;
                    txtCDesc.Text = secilenItem.Description;
                    cmbState.Text = secilenItem.IsActive ? "Aktif" : "Pasif";
                }
            }
        }
        

    }
}
