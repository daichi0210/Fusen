namespace Fusen
{
    public partial class FormFusen : Form
    {
        // マウスの横位置（X座標）
        // マウスの縦位置（Y座標）
        
        public FormFusen()
        {
            InitializeComponent();
        }

        // テキストボックスにキーボードから文字を入力したとき
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            // ＜判定＞押されたキーがエスケープキー？
            // Yesの場合
            // アプリケーションを終了
        }

        // テキストボックスをマウスでクリックしたとき
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            // ＜判定＞押されたボタンがマウスの左ボタン？
            // Yesの場合
            // マウスの横位置（X座標）を記憶
            // マウスの縦位置（Y座標）を記憶
        }

        // テキストボックスをマウスでダブルクリックしたとき
        private void textFusenMemo_DoubleClick(object sender, EventArgs e)
        {
            // 色の設定ダイアログを表示する
            // テキストボックスの背景色を色の設定ダイアログで選んだ色に設定する
        }

        // テキストボックスでクリックしたマウスを移動させたとき
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            // ＜判定＞押されたボタンがマウスの左ボタン？
            // Yesの場合
            // フォームの横位置（X座標）を更新
            // フォームの縦位置（Y座標）を更新
        }
    }
}
