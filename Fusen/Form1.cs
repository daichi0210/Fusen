namespace Fusen
{
    public partial class FormFusen : Form
    {
        private int mouseX; // �}�E�X�̉��ʒu�iX���W�j
        private int mouseY; // �}�E�X�̏c�ʒu�iY���W�j
        
        public FormFusen()
        {
            InitializeComponent();
        }

        // �e�L�X�g�{�b�N�X�ɃL�[�{�[�h���當������͂����Ƃ�
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            // �����聄�����ꂽ�L�[���G�X�P�[�v�L�[�H
            if (e.KeyCode == Keys.Escape) {
                // Yes�̏ꍇ
                // �A�v���P�[�V�������I��
                this.Close();
            }
        }

        // �e�L�X�g�{�b�N�X���}�E�X�ŃN���b�N�����Ƃ�
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            // �����聄�����ꂽ�{�^�����}�E�X�̍��{�^���H
            if (e.Button == MouseButtons.Left)
            {
                // Yes�̏ꍇ
                this.mouseX = e.X;  // �}�E�X�̉��ʒu�iX���W�j���L��
                this.mouseY = e.Y;  // �}�E�X�̏c�ʒu�iY���W�j���L��
            }
        }

        // �e�L�X�g�{�b�N�X���}�E�X�Ń_�u���N���b�N�����Ƃ�
        private void textFusenMemo_DoubleClick(object sender, EventArgs e)
        {
            // �F�̐ݒ�_�C�A���O��\������
            colorDialogFusen.ShowDialog();
            // �e�L�X�g�{�b�N�X�̔w�i�F��F�̐ݒ�_�C�A���O�őI�񂾐F�ɐݒ肷��
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }

        // �e�L�X�g�{�b�N�X�ŃN���b�N�����}�E�X���ړ��������Ƃ�
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            // �����聄�����ꂽ�{�^�����}�E�X�̍��{�^���H
            if (e.Button == MouseButtons.Left)
            {
                // Yes�̏ꍇ
                this.Left += e.X - mouseX;  // �t�H�[���̉��ʒu�iX���W�j���X�V
                this.Top += e.Y - mouseY;   // �t�H�[���̏c�ʒu�iY���W�j���X�V
            }
        }
    }
}
