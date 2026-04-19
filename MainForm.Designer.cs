namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriespage = new System.Windows.Forms.TabPage();
            this.countriesGridView = new System.Windows.Forms.DataGridView();
            this.countryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletecountry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.citypage = new System.Windows.Forms.TabPage();
            this.cityGridView = new System.Windows.Forms.DataGridView();
            this.cityid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citycountryname = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deletecity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hotelpage = new System.Windows.Forms.TabPage();
            this.hotelGridView = new System.Windows.Forms.DataGridView();
            this.hotelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelcityid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.food = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletehotel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.transportpage = new System.Windows.Forms.TabPage();
            this.transportGridView = new System.Windows.Forms.DataGridView();
            this.transportid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletetransport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tourpage = new System.Windows.Forms.TabPage();
            this.tourGridView = new System.Windows.Forms.DataGridView();
            this.tourid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotels_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourtransportid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.touroption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletetour = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientpage = new System.Windows.Forms.TabPage();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientpatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientbirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientpassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clintemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteclient = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.requestpage = new System.Windows.Forms.TabPage();
            this.requestGridView = new System.Windows.Forms.DataGridView();
            this.requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestclirntid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requesttourid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requetstartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestfinishdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleterequest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MainLaypoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.changePanel = new System.Windows.Forms.Panel();
            this.contextSearchTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.aceptButton = new System.Windows.Forms.Button();
            this.mainmenustrip.SuspendLayout();
            this.countriespage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridView)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.citypage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).BeginInit();
            this.hotelpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).BeginInit();
            this.transportpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportGridView)).BeginInit();
            this.tourpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).BeginInit();
            this.clientpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            this.requestpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).BeginInit();
            this.MainLaypoutPanel.SuspendLayout();
            this.changePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenustrip
            // 
            this.mainmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.refToolStripMenuItem,
            this.delToolStripMenuitem,
            this.changeToolStripMenuItem});
            this.mainmenustrip.Name = "contextMenuStrip1";
            this.mainmenustrip.Size = new System.Drawing.Size(129, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // refToolStripMenuItem
            // 
            this.refToolStripMenuItem.Name = "refToolStripMenuItem";
            this.refToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.refToolStripMenuItem.Text = "Обновить";
            this.refToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // delToolStripMenuitem
            // 
            this.delToolStripMenuitem.Name = "delToolStripMenuitem";
            this.delToolStripMenuitem.Size = new System.Drawing.Size(128, 22);
            this.delToolStripMenuitem.Text = "Удалить";
            this.delToolStripMenuitem.Click += new System.EventHandler(this.delToolStripMenuitem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // countriespage
            // 
            this.countriespage.Controls.Add(this.countriesGridView);
            this.countriespage.Location = new System.Drawing.Point(4, 33);
            this.countriespage.Name = "countriespage";
            this.countriespage.Padding = new System.Windows.Forms.Padding(3);
            this.countriespage.Size = new System.Drawing.Size(1097, 394);
            this.countriespage.TabIndex = 1;
            this.countriespage.Text = "Страны";
            this.countriespage.UseVisualStyleBackColor = true;
            // 
            // countriesGridView
            // 
            this.countriesGridView.AllowUserToAddRows = false;
            this.countriesGridView.AllowUserToDeleteRows = false;
            this.countriesGridView.AllowUserToResizeColumns = false;
            this.countriesGridView.AllowUserToResizeRows = false;
            this.countriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.countriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryid,
            this.countryname,
            this.countrycode,
            this.deletecountry});
            this.countriesGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.countriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesGridView.Location = new System.Drawing.Point(3, 3);
            this.countriesGridView.Name = "countriesGridView";
            this.countriesGridView.ReadOnly = true;
            this.countriesGridView.RowHeadersVisible = false;
            this.countriesGridView.Size = new System.Drawing.Size(1091, 388);
            this.countriesGridView.TabIndex = 0;
            // 
            // countryid
            // 
            this.countryid.HeaderText = "ID";
            this.countryid.Name = "countryid";
            this.countryid.ReadOnly = true;
            this.countryid.Width = 52;
            // 
            // countryname
            // 
            this.countryname.HeaderText = "Название Страны";
            this.countryname.Name = "countryname";
            this.countryname.ReadOnly = true;
            this.countryname.Width = 178;
            // 
            // countrycode
            // 
            this.countrycode.HeaderText = "Код Страны";
            this.countrycode.Name = "countrycode";
            this.countrycode.ReadOnly = true;
            this.countrycode.Width = 131;
            // 
            // deletecountry
            // 
            this.deletecountry.HeaderText = "Удалить";
            this.deletecountry.Name = "deletecountry";
            this.deletecountry.ReadOnly = true;
            this.deletecountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletecountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletecountry.Visible = false;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.countriespage);
            this.MainTabControl.Controls.Add(this.citypage);
            this.MainTabControl.Controls.Add(this.hotelpage);
            this.MainTabControl.Controls.Add(this.transportpage);
            this.MainTabControl.Controls.Add(this.tourpage);
            this.MainTabControl.Controls.Add(this.clientpage);
            this.MainTabControl.Controls.Add(this.requestpage);
            this.MainTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1105, 431);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // citypage
            // 
            this.citypage.Controls.Add(this.cityGridView);
            this.citypage.Location = new System.Drawing.Point(4, 33);
            this.citypage.Name = "citypage";
            this.citypage.Size = new System.Drawing.Size(1097, 394);
            this.citypage.TabIndex = 2;
            this.citypage.Text = "города";
            this.citypage.UseVisualStyleBackColor = true;
            // 
            // cityGridView
            // 
            this.cityGridView.AllowUserToAddRows = false;
            this.cityGridView.AllowUserToResizeColumns = false;
            this.cityGridView.AllowUserToResizeRows = false;
            this.cityGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.cityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityid,
            this.cityname,
            this.citycountryname,
            this.deletecity});
            this.cityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityGridView.Location = new System.Drawing.Point(0, 0);
            this.cityGridView.Name = "cityGridView";
            this.cityGridView.ReadOnly = true;
            this.cityGridView.RowHeadersVisible = false;
            this.cityGridView.Size = new System.Drawing.Size(1097, 394);
            this.cityGridView.TabIndex = 0;
            // 
            // cityid
            // 
            this.cityid.HeaderText = "ID";
            this.cityid.Name = "cityid";
            this.cityid.ReadOnly = true;
            this.cityid.Width = 52;
            // 
            // cityname
            // 
            this.cityname.HeaderText = "Название";
            this.cityname.Name = "cityname";
            this.cityname.ReadOnly = true;
            this.cityname.Width = 122;
            // 
            // citycountryname
            // 
            this.citycountryname.HeaderText = "Страна";
            this.citycountryname.Name = "citycountryname";
            this.citycountryname.ReadOnly = true;
            this.citycountryname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.citycountryname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deletecity
            // 
            this.deletecity.HeaderText = "Удалить";
            this.deletecity.Name = "deletecity";
            this.deletecity.ReadOnly = true;
            this.deletecity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletecity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletecity.Visible = false;
            // 
            // hotelpage
            // 
            this.hotelpage.Controls.Add(this.hotelGridView);
            this.hotelpage.Location = new System.Drawing.Point(4, 33);
            this.hotelpage.Name = "hotelpage";
            this.hotelpage.Size = new System.Drawing.Size(1097, 394);
            this.hotelpage.TabIndex = 3;
            this.hotelpage.Text = "отели";
            this.hotelpage.UseVisualStyleBackColor = true;
            // 
            // hotelGridView
            // 
            this.hotelGridView.AllowUserToAddRows = false;
            this.hotelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.hotelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelid,
            this.hotelname,
            this.hotelcityid,
            this.food,
            this.price,
            this.deletehotel});
            this.hotelGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelGridView.Location = new System.Drawing.Point(0, 0);
            this.hotelGridView.Name = "hotelGridView";
            this.hotelGridView.ReadOnly = true;
            this.hotelGridView.RowHeadersVisible = false;
            this.hotelGridView.Size = new System.Drawing.Size(1097, 394);
            this.hotelGridView.TabIndex = 0;
            // 
            // hotelid
            // 
            this.hotelid.HeaderText = "id";
            this.hotelid.Name = "hotelid";
            this.hotelid.ReadOnly = true;
            this.hotelid.Width = 50;
            // 
            // hotelname
            // 
            this.hotelname.HeaderText = "Название отеля";
            this.hotelname.Name = "hotelname";
            this.hotelname.ReadOnly = true;
            this.hotelname.Width = 163;
            // 
            // hotelcityid
            // 
            this.hotelcityid.HeaderText = "Назваие города";
            this.hotelcityid.Name = "hotelcityid";
            this.hotelcityid.ReadOnly = true;
            this.hotelcityid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelcityid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hotelcityid.Width = 164;
            // 
            // food
            // 
            this.food.HeaderText = "Еда";
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.food.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.food.Width = 70;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 79;
            // 
            // deletehotel
            // 
            this.deletehotel.HeaderText = "Удалить";
            this.deletehotel.Name = "deletehotel";
            this.deletehotel.ReadOnly = true;
            this.deletehotel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletehotel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletehotel.Visible = false;
            // 
            // transportpage
            // 
            this.transportpage.Controls.Add(this.transportGridView);
            this.transportpage.Location = new System.Drawing.Point(4, 33);
            this.transportpage.Name = "transportpage";
            this.transportpage.Size = new System.Drawing.Size(1097, 394);
            this.transportpage.TabIndex = 4;
            this.transportpage.Text = "транспорт";
            this.transportpage.UseVisualStyleBackColor = true;
            // 
            // transportGridView
            // 
            this.transportGridView.AllowUserToAddRows = false;
            this.transportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.transportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportid,
            this.transportname,
            this.transportprice,
            this.deletetransport});
            this.transportGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportGridView.Location = new System.Drawing.Point(0, 0);
            this.transportGridView.Name = "transportGridView";
            this.transportGridView.ReadOnly = true;
            this.transportGridView.RowHeadersVisible = false;
            this.transportGridView.Size = new System.Drawing.Size(1097, 394);
            this.transportGridView.TabIndex = 0;
            // 
            // transportid
            // 
            this.transportid.HeaderText = "ID";
            this.transportid.Name = "transportid";
            this.transportid.ReadOnly = true;
            this.transportid.Width = 52;
            // 
            // transportname
            // 
            this.transportname.HeaderText = "Название";
            this.transportname.Name = "transportname";
            this.transportname.ReadOnly = true;
            this.transportname.Width = 122;
            // 
            // transportprice
            // 
            this.transportprice.HeaderText = "Цена";
            this.transportprice.Name = "transportprice";
            this.transportprice.ReadOnly = true;
            this.transportprice.Width = 79;
            // 
            // deletetransport
            // 
            this.deletetransport.HeaderText = "Удалить";
            this.deletetransport.Name = "deletetransport";
            this.deletetransport.ReadOnly = true;
            this.deletetransport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletetransport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletetransport.Visible = false;
            // 
            // tourpage
            // 
            this.tourpage.Controls.Add(this.tourGridView);
            this.tourpage.Location = new System.Drawing.Point(4, 33);
            this.tourpage.Name = "tourpage";
            this.tourpage.Size = new System.Drawing.Size(1097, 394);
            this.tourpage.TabIndex = 5;
            this.tourpage.Text = "туры";
            this.tourpage.UseVisualStyleBackColor = true;
            // 
            // tourGridView
            // 
            this.tourGridView.AllowUserToAddRows = false;
            this.tourGridView.AllowUserToDeleteRows = false;
            this.tourGridView.AllowUserToResizeColumns = false;
            this.tourGridView.AllowUserToResizeRows = false;
            this.tourGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourid,
            this.tourname,
            this.hotels_id,
            this.tourcount,
            this.tourtransportid,
            this.touroption,
            this.deletetour});
            this.tourGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourGridView.Location = new System.Drawing.Point(0, 0);
            this.tourGridView.Name = "tourGridView";
            this.tourGridView.ReadOnly = true;
            this.tourGridView.RowHeadersVisible = false;
            this.tourGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tourGridView.Size = new System.Drawing.Size(1097, 394);
            this.tourGridView.TabIndex = 0;
            // 
            // tourid
            // 
            this.tourid.HeaderText = "ID";
            this.tourid.Name = "tourid";
            this.tourid.ReadOnly = true;
            this.tourid.Width = 52;
            // 
            // tourname
            // 
            this.tourname.HeaderText = "Название";
            this.tourname.Name = "tourname";
            this.tourname.ReadOnly = true;
            this.tourname.Width = 122;
            // 
            // hotels_id
            // 
            this.hotels_id.HeaderText = "Отель(и)";
            this.hotels_id.Name = "hotels_id";
            this.hotels_id.ReadOnly = true;
            this.hotels_id.Width = 115;
            // 
            // tourcount
            // 
            this.tourcount.HeaderText = "Кол-во дней";
            this.tourcount.Name = "tourcount";
            this.tourcount.ReadOnly = true;
            this.tourcount.Width = 146;
            // 
            // tourtransportid
            // 
            this.tourtransportid.HeaderText = "Транспорт";
            this.tourtransportid.Name = "tourtransportid";
            this.tourtransportid.ReadOnly = true;
            this.tourtransportid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tourtransportid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tourtransportid.Width = 132;
            // 
            // touroption
            // 
            this.touroption.HeaderText = "Описание";
            this.touroption.Name = "touroption";
            this.touroption.ReadOnly = true;
            this.touroption.Width = 125;
            // 
            // deletetour
            // 
            this.deletetour.HeaderText = "Удалить";
            this.deletetour.Name = "deletetour";
            this.deletetour.ReadOnly = true;
            this.deletetour.Visible = false;
            this.deletetour.Width = 92;
            // 
            // clientpage
            // 
            this.clientpage.Controls.Add(this.clientGridView);
            this.clientpage.Location = new System.Drawing.Point(4, 33);
            this.clientpage.Name = "clientpage";
            this.clientpage.Size = new System.Drawing.Size(1097, 394);
            this.clientpage.TabIndex = 6;
            this.clientpage.Text = "клиенты";
            this.clientpage.UseVisualStyleBackColor = true;
            // 
            // clientGridView
            // 
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientId,
            this.clientname,
            this.clientsurname,
            this.clientpatronymic,
            this.clientbirthday,
            this.clientpassport,
            this.clientphone,
            this.clintemail,
            this.deleteclient});
            this.clientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientGridView.Location = new System.Drawing.Point(0, 0);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowHeadersVisible = false;
            this.clientGridView.Size = new System.Drawing.Size(1097, 394);
            this.clientGridView.TabIndex = 0;
            // 
            // clientId
            // 
            this.clientId.HeaderText = "ID";
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            this.clientId.Width = 52;
            // 
            // clientname
            // 
            this.clientname.HeaderText = "Имя";
            this.clientname.Name = "clientname";
            this.clientname.ReadOnly = true;
            this.clientname.Width = 71;
            // 
            // clientsurname
            // 
            this.clientsurname.HeaderText = "Фамилия";
            this.clientsurname.Name = "clientsurname";
            this.clientsurname.ReadOnly = true;
            this.clientsurname.Width = 116;
            // 
            // clientpatronymic
            // 
            this.clientpatronymic.HeaderText = "Отчество";
            this.clientpatronymic.Name = "clientpatronymic";
            this.clientpatronymic.ReadOnly = true;
            this.clientpatronymic.Width = 123;
            // 
            // clientbirthday
            // 
            this.clientbirthday.HeaderText = "День рожденья";
            this.clientbirthday.Name = "clientbirthday";
            this.clientbirthday.ReadOnly = true;
            this.clientbirthday.Width = 162;
            // 
            // clientpassport
            // 
            this.clientpassport.HeaderText = "Серия и номер";
            this.clientpassport.Name = "clientpassport";
            this.clientpassport.ReadOnly = true;
            this.clientpassport.Width = 154;
            // 
            // clientphone
            // 
            this.clientphone.HeaderText = "Номер телефона";
            this.clientphone.Name = "clientphone";
            this.clientphone.ReadOnly = true;
            this.clientphone.Width = 170;
            // 
            // clintemail
            // 
            this.clintemail.HeaderText = "Email";
            this.clintemail.Name = "clintemail";
            this.clintemail.ReadOnly = true;
            this.clintemail.Width = 82;
            // 
            // deleteclient
            // 
            this.deleteclient.HeaderText = "Удалить";
            this.deleteclient.Name = "deleteclient";
            this.deleteclient.ReadOnly = true;
            this.deleteclient.Visible = false;
            // 
            // requestpage
            // 
            this.requestpage.Controls.Add(this.requestGridView);
            this.requestpage.Location = new System.Drawing.Point(4, 33);
            this.requestpage.Name = "requestpage";
            this.requestpage.Size = new System.Drawing.Size(1097, 394);
            this.requestpage.TabIndex = 7;
            this.requestpage.Text = "заявки";
            this.requestpage.UseVisualStyleBackColor = true;
            // 
            // requestGridView
            // 
            this.requestGridView.AllowUserToAddRows = false;
            this.requestGridView.AllowUserToDeleteRows = false;
            this.requestGridView.AllowUserToResizeColumns = false;
            this.requestGridView.AllowUserToResizeRows = false;
            this.requestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.requestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestid,
            this.requestclirntid,
            this.requesttourid,
            this.requetstartdate,
            this.requestfinishdate,
            this.status,
            this.deleterequest});
            this.requestGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestGridView.Location = new System.Drawing.Point(0, 0);
            this.requestGridView.Name = "requestGridView";
            this.requestGridView.ReadOnly = true;
            this.requestGridView.RowHeadersVisible = false;
            this.requestGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestGridView.Size = new System.Drawing.Size(1097, 394);
            this.requestGridView.TabIndex = 0;
            // 
            // requestid
            // 
            this.requestid.HeaderText = "ID";
            this.requestid.Name = "requestid";
            this.requestid.ReadOnly = true;
            this.requestid.Width = 52;
            // 
            // requestclirntid
            // 
            this.requestclirntid.HeaderText = "Краткая информация о клиенте";
            this.requestclirntid.Name = "requestclirntid";
            this.requestclirntid.ReadOnly = true;
            this.requestclirntid.Width = 289;
            // 
            // requesttourid
            // 
            this.requesttourid.HeaderText = "Название тура";
            this.requesttourid.Name = "requesttourid";
            this.requesttourid.ReadOnly = true;
            this.requesttourid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.requesttourid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.requesttourid.Width = 152;
            // 
            // requetstartdate
            // 
            this.requetstartdate.HeaderText = "Дата начала";
            this.requetstartdate.Name = "requetstartdate";
            this.requetstartdate.ReadOnly = true;
            this.requetstartdate.Width = 133;
            // 
            // requestfinishdate
            // 
            this.requestfinishdate.HeaderText = "Конец Тура";
            this.requestfinishdate.Name = "requestfinishdate";
            this.requestfinishdate.ReadOnly = true;
            this.requestfinishdate.Width = 126;
            // 
            // status
            // 
            this.status.HeaderText = "Статус заявки";
            this.status.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 130;
            // 
            // deleterequest
            // 
            this.deleterequest.HeaderText = "Удалить";
            this.deleterequest.Name = "deleterequest";
            this.deleterequest.ReadOnly = true;
            this.deleterequest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleterequest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleterequest.Visible = false;
            this.deleterequest.Width = 111;
            // 
            // MainLaypoutPanel
            // 
            this.MainLaypoutPanel.ColumnCount = 1;
            this.MainLaypoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLaypoutPanel.Controls.Add(this.MainTabControl, 0, 0);
            this.MainLaypoutPanel.Controls.Add(this.changePanel, 0, 1);
            this.MainLaypoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLaypoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLaypoutPanel.Name = "MainLaypoutPanel";
            this.MainLaypoutPanel.RowCount = 2;
            this.MainLaypoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLaypoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLaypoutPanel.Size = new System.Drawing.Size(954, 488);
            this.MainLaypoutPanel.TabIndex = 1;
            // 
            // changePanel
            // 
            this.changePanel.Controls.Add(this.contextSearchTextBox);
            this.changePanel.Controls.Add(this.cancelButton);
            this.changePanel.Controls.Add(this.aceptButton);
            this.changePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePanel.Location = new System.Drawing.Point(3, 440);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(1105, 45);
            this.changePanel.TabIndex = 1;
            // 
            // contextSearchTextBox
            // 
            this.contextSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextSearchTextBox.Location = new System.Drawing.Point(333, 8);
            this.contextSearchTextBox.Name = "contextSearchTextBox";
            this.contextSearchTextBox.Size = new System.Drawing.Size(386, 31);
            this.contextSearchTextBox.TabIndex = 2;
            this.contextSearchTextBox.TextChanged += new System.EventHandler(this.searchContextTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(153, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 33);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // aceptButton
            // 
            this.aceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aceptButton.Location = new System.Drawing.Point(4, 6);
            this.aceptButton.Name = "aceptButton";
            this.aceptButton.Size = new System.Drawing.Size(143, 33);
            this.aceptButton.TabIndex = 0;
            this.aceptButton.Text = "Подтвердить";
            this.aceptButton.UseVisualStyleBackColor = true;
            this.aceptButton.Visible = false;
            this.aceptButton.Click += new System.EventHandler(this.aceptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 488);
            this.ContextMenuStrip = this.mainmenustrip;
            this.Controls.Add(this.MainLaypoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "ATAS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainmenustrip.ResumeLayout(false);
            this.countriespage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridView)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.citypage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).EndInit();
            this.hotelpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).EndInit();
            this.transportpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportGridView)).EndInit();
            this.tourpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourGridView)).EndInit();
            this.clientpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            this.requestpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestGridView)).EndInit();
            this.MainLaypoutPanel.ResumeLayout(false);
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip mainmenustrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.TabPage countriespage;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        internal System.Windows.Forms.DataGridView countriesGridView;
        private System.Windows.Forms.TabPage citypage;
        private System.Windows.Forms.TabPage hotelpage;
        private System.Windows.Forms.TabPage transportpage;
        private System.Windows.Forms.TabPage tourpage;
        private System.Windows.Forms.TabPage clientpage;
        private System.Windows.Forms.TabPage requestpage;
        private System.Windows.Forms.DataGridView cityGridView;
        private System.Windows.Forms.DataGridView hotelGridView;
        private System.Windows.Forms.DataGridView transportGridView;
        private System.Windows.Forms.DataGridView tourGridView;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.DataGridView requestGridView;
        private System.Windows.Forms.TableLayoutPanel MainLaypoutPanel;
        private System.Windows.Forms.Panel changePanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button aceptButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletecountry;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportid;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportname;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportprice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletetransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientpatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientbirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientpassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clintemail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityname;
        private System.Windows.Forms.DataGridViewComboBoxColumn citycountryname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletecity;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelname;
        private System.Windows.Forms.DataGridViewComboBoxColumn hotelcityid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletehotel;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        internal System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TextBox contextSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotels_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourcount;
        private System.Windows.Forms.DataGridViewComboBoxColumn tourtransportid;
        private System.Windows.Forms.DataGridViewTextBoxColumn touroption;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestclirntid;
        private System.Windows.Forms.DataGridViewComboBoxColumn requesttourid;
        private System.Windows.Forms.DataGridViewTextBoxColumn requetstartdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestfinishdate;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleterequest;
    }
}

