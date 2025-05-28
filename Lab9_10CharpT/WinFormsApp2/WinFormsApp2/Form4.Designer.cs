namespace MusicCatalog
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxDisk, textBoxTitle, textBoxArtist;
        private Button buttonAddDisk, buttonRemoveDisk, buttonAddSong, buttonRemoveSong;
        private Button buttonViewDisk, buttonViewAll, buttonSearchArtist;
        private ListBox listBoxOutput;

        private void InitializeComponent()
        {
            this.textBoxDisk = new TextBox();
            this.textBoxTitle = new TextBox();
            this.textBoxArtist = new TextBox();
            this.buttonAddDisk = new Button();
            this.buttonRemoveDisk = new Button();
            this.buttonAddSong = new Button();
            this.buttonRemoveSong = new Button();
            this.buttonViewDisk = new Button();
            this.buttonViewAll = new Button();
            this.buttonSearchArtist = new Button();
            this.listBoxOutput = new ListBox();

            // Controls setup
            this.textBoxDisk.SetBounds(30, 20, 150, 25);
            this.textBoxDisk.PlaceholderText = "Назва диску";

            this.textBoxTitle.SetBounds(30, 55, 150, 25);
            this.textBoxTitle.PlaceholderText = "Назва пісні";

            this.textBoxArtist.SetBounds(30, 90, 150, 25);
            this.textBoxArtist.PlaceholderText = "Виконавець";

            this.buttonAddDisk.SetBounds(200, 20, 120, 30);
            this.buttonAddDisk.Text = "Додати диск";
            this.buttonAddDisk.Click += new EventHandler(this.buttonAddDisk_Click);

            this.buttonRemoveDisk.SetBounds(330, 20, 120, 30);
            this.buttonRemoveDisk.Text = "Видалити диск";
            this.buttonRemoveDisk.Click += new EventHandler(this.buttonRemoveDisk_Click);

            this.buttonAddSong.SetBounds(200, 55, 120, 30);
            this.buttonAddSong.Text = "Додати пісню";
            this.buttonAddSong.Click += new EventHandler(this.buttonAddSong_Click);

            this.buttonRemoveSong.SetBounds(330, 55, 120, 30);
            this.buttonRemoveSong.Text = "Видалити пісню";
            this.buttonRemoveSong.Click += new EventHandler(this.buttonRemoveSong_Click);

            this.buttonViewDisk.SetBounds(200, 90, 120, 30);
            this.buttonViewDisk.Text = "Перегляд диска";
            this.buttonViewDisk.Click += new EventHandler(this.buttonViewDisk_Click);

            this.buttonViewAll.SetBounds(330, 90, 120, 30);
            this.buttonViewAll.Text = "Весь каталог";
            this.buttonViewAll.Click += new EventHandler(this.buttonViewAll_Click);

            this.buttonSearchArtist.SetBounds(200, 125, 250, 30);
            this.buttonSearchArtist.Text = "Пошук за виконавцем";
            this.buttonSearchArtist.Click += new EventHandler(this.buttonSearchArtist_Click);

            this.listBoxOutput.SetBounds(30, 170, 500, 300);

            this.Controls.AddRange(new Control[] {
                textBoxDisk, textBoxTitle, textBoxArtist,
                buttonAddDisk, buttonRemoveDisk,
                buttonAddSong, buttonRemoveSong,
                buttonViewDisk, buttonViewAll, buttonSearchArtist,
                listBoxOutput
            });

            this.ClientSize = new System.Drawing.Size(580, 500);
            this.Text = "Форма 4 — Каталог музичних дисків";
        }
    }
}
