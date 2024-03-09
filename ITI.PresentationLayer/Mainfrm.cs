using ITI.BusnissLogicLayer.Dtos;
using ITI.BusnissLogicLayer.Services;

namespace ITI.PresentationLayer
{
    public partial class Mainfrm : Form
    {
        private int _crsId = default;
        private int _topicId = default;
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void LoadCoursesData()
        {
            dataGridCrs.DataSource = CourseService.GetAllCourses();
            dataGridCrs.Columns["Top_Id"].Visible = false;
            dataGridCrs.Columns["Crs_Id"].Visible = false;
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            LoadCoursesData();

            combo_Topic.DataSource = TopicService.GetAllTopics();
            combo_Topic.DisplayMember = "Top_Name";
            combo_Topic.ValueMember = "Top_Id";
            combo_Topic.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CourseDto course = new CourseDto()
            {
                Crs_Id = CourseService.GetMaxCrsIdIncrement(),
                Crs_Name = txt_CrsName.Text,
                Crs_Duration = (int)num_CrsDuration.Value,
                Top_Id = (int)combo_Topic.SelectedValue
            };

            //Func<bool> result = () => CourseService.SaveCourse(course) > 0;

            if (CourseService.SaveCourse(course) > 0)
            {
                MessageBox.Show("Course saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCoursesData();

            ControlManager.ControlManager.ClearAllTextBoxes(this.Controls);
            num_CrsDuration.Value = 0;
            combo_Topic.SelectedIndex = -1;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CourseDto course = new CourseDto()
            {
                Crs_Id = _crsId,
                Crs_Name = txt_CrsName.Text,
                Crs_Duration = (int)num_CrsDuration.Value,
                Top_Id = (int)combo_Topic.SelectedValue
            };

            Func<bool> result = () => CourseService.UpdateCourse(course) > 0;

            if (result())
            {
                MessageBox.Show("Course Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCoursesData();

            ControlManager.ControlManager.ClearAllTextBoxes(this.Controls);
            num_CrsDuration.Value = 0;
            combo_Topic.SelectedIndex = -1;

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private void dataGridCrs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridCrs.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridCrs.Rows[e.RowIndex];

                _crsId = Convert.ToInt32(selectedRow.Cells["Crs_Id"].Value);

                _topicId = Convert.ToInt32(selectedRow.Cells["Top_Id"].Value);

                num_CrsDuration.Value = Convert.ToDecimal(selectedRow.Cells["Crs_Duration"].Value);
                combo_Topic.SelectedValue = _topicId;
                txt_CrsName.Text = selectedRow.Cells["Crs_Name"].Value.ToString();

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show($"Delete the Course Number {_crsId} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultDialog == DialogResult.Yes)
            {
                Func<bool> result = () => CourseService.DeleteCourse(_crsId) > 0;

                if (result())
                {
                    MessageBox.Show("Course Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadCoursesData();

            ControlManager.ControlManager.ClearAllTextBoxes(this.Controls);
            num_CrsDuration.Value = 0;
            combo_Topic.SelectedIndex = -1;

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }
    }
}
