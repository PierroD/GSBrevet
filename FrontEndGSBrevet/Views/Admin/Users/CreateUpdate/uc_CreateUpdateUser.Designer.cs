namespace FrontEndGSBrevet.Views.Admin.Users.CreateUpdate
{
    partial class uc_CreateUpdateUser
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_lastname = new Guna.UI.WinForms.GunaLabel();
            this.tbox_lastname = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbox_firstname = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_firstname = new Guna.UI.WinForms.GunaLabel();
            this.tbox_username = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_username = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_send_to_database = new Guna.UI.WinForms.GunaTileButton();
            this.btn_back_to_AllUsers = new Guna.UI.WinForms.GunaButton();
            this.tbox_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_password = new Guna.UI.WinForms.GunaLabel();
            this.dtime_birthDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_birthDate = new Guna.UI.WinForms.GunaLabel();
            this.cbox_role = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_role = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(302, 48);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(182, 25);
            this.lbl_lastname.TabIndex = 9;
            this.lbl_lastname.Text = "Nom de l\'utilisateur";
            // 
            // tbox_lastname
            // 
            this.tbox_lastname.BackColor = System.Drawing.Color.White;
            this.tbox_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_lastname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_lastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_lastname.ForeColor = System.Drawing.Color.Gray;
            this.tbox_lastname.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_lastname.Location = new System.Drawing.Point(307, 76);
            this.tbox_lastname.Name = "tbox_lastname";
            this.tbox_lastname.PasswordChar = '\0';
            this.tbox_lastname.Size = new System.Drawing.Size(473, 36);
            this.tbox_lastname.TabIndex = 10;
            this.tbox_lastname.Text = "Renseignez un nom";
            this.tbox_lastname.Enter += new System.EventHandler(this.tbox_lastname_Enter);
            this.tbox_lastname.Leave += new System.EventHandler(this.tbox_lastname_Leave);
            // 
            // tbox_firstname
            // 
            this.tbox_firstname.BackColor = System.Drawing.Color.White;
            this.tbox_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_firstname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_firstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_firstname.ForeColor = System.Drawing.Color.Gray;
            this.tbox_firstname.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_firstname.Location = new System.Drawing.Point(307, 161);
            this.tbox_firstname.Name = "tbox_firstname";
            this.tbox_firstname.PasswordChar = '\0';
            this.tbox_firstname.Size = new System.Drawing.Size(473, 36);
            this.tbox_firstname.TabIndex = 12;
            this.tbox_firstname.Text = "Renseignez un prénom";
            this.tbox_firstname.Enter += new System.EventHandler(this.tbox_firstname_Enter);
            this.tbox_firstname.Leave += new System.EventHandler(this.tbox_firstname_Leave);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(302, 133);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(206, 25);
            this.lbl_firstname.TabIndex = 11;
            this.lbl_firstname.Text = "Prénom de l\'utilisateur";
            // 
            // tbox_username
            // 
            this.tbox_username.BackColor = System.Drawing.Color.White;
            this.tbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_username.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_username.ForeColor = System.Drawing.Color.Gray;
            this.tbox_username.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_username.Location = new System.Drawing.Point(307, 242);
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.PasswordChar = '\0';
            this.tbox_username.Size = new System.Drawing.Size(473, 36);
            this.tbox_username.TabIndex = 14;
            this.tbox_username.Text = "Renseignez un identifiant";
            this.tbox_username.Enter += new System.EventHandler(this.tbox_username_Enter);
            this.tbox_username.Leave += new System.EventHandler(this.tbox_username_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(302, 214);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(229, 25);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "Identifiant de l\'utilisateur";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(165, 547);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(778, 10);
            this.gunaSeparator1.TabIndex = 15;
            // 
            // btn_send_to_database
            // 
            this.btn_send_to_database.AnimationHoverSpeed = 0.07F;
            this.btn_send_to_database.AnimationSpeed = 0.03F;
            this.btn_send_to_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_send_to_database.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_send_to_database.BorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_send_to_database.FocusedColor = System.Drawing.Color.Empty;
            this.btn_send_to_database.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btn_send_to_database.ForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.Image = global::FrontEndGSBrevet.Properties.Resources.save;
            this.btn_send_to_database.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_send_to_database.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_send_to_database.Location = new System.Drawing.Point(419, 582);
            this.btn_send_to_database.Name = "btn_send_to_database";
            this.btn_send_to_database.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_send_to_database.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_send_to_database.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_send_to_database.OnHoverImage = null;
            this.btn_send_to_database.OnPressedColor = System.Drawing.Color.Black;
            this.btn_send_to_database.Radius = 10;
            this.btn_send_to_database.Size = new System.Drawing.Size(229, 69);
            this.btn_send_to_database.TabIndex = 16;
            this.btn_send_to_database.Text = "Mettre à jour";
            this.btn_send_to_database.Click += new System.EventHandler(this.btn_send_to_database_Click);
            // 
            // btn_back_to_AllUsers
            // 
            this.btn_back_to_AllUsers.AnimationHoverSpeed = 0.07F;
            this.btn_back_to_AllUsers.AnimationSpeed = 0.03F;
            this.btn_back_to_AllUsers.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_to_AllUsers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_back_to_AllUsers.BorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back_to_AllUsers.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back_to_AllUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_to_AllUsers.ForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllUsers.Image = global::FrontEndGSBrevet.Properties.Resources.back;
            this.btn_back_to_AllUsers.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_back_to_AllUsers.Location = new System.Drawing.Point(3, 3);
            this.btn_back_to_AllUsers.Name = "btn_back_to_AllUsers";
            this.btn_back_to_AllUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.btn_back_to_AllUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back_to_AllUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_back_to_AllUsers.OnHoverImage = null;
            this.btn_back_to_AllUsers.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back_to_AllUsers.Radius = 6;
            this.btn_back_to_AllUsers.Size = new System.Drawing.Size(182, 42);
            this.btn_back_to_AllUsers.TabIndex = 8;
            this.btn_back_to_AllUsers.Text = "Tous les utilisateurs";
            this.btn_back_to_AllUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back_to_AllUsers.Click += new System.EventHandler(this.btn_back_to_AllUsers_Click);
            // 
            // tbox_password
            // 
            this.tbox_password.BackColor = System.Drawing.Color.White;
            this.tbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbox_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbox_password.ForeColor = System.Drawing.Color.Gray;
            this.tbox_password.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_password.Location = new System.Drawing.Point(307, 324);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '\0';
            this.tbox_password.Size = new System.Drawing.Size(473, 36);
            this.tbox_password.TabIndex = 18;
            this.tbox_password.Text = "Renseignez un mot de passe";
            this.tbox_password.Enter += new System.EventHandler(this.tbox_password_Enter);
            this.tbox_password.Leave += new System.EventHandler(this.tbox_password_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(302, 296);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(253, 25);
            this.lbl_password.TabIndex = 17;
            this.lbl_password.Text = "Mot de passe de l\'utilisateur";
            // 
            // dtime_birthDate
            // 
            this.dtime_birthDate.BaseColor = System.Drawing.Color.White;
            this.dtime_birthDate.BorderColor = System.Drawing.Color.Silver;
            this.dtime_birthDate.CustomFormat = null;
            this.dtime_birthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtime_birthDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_birthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtime_birthDate.ForeColor = System.Drawing.Color.Black;
            this.dtime_birthDate.Location = new System.Drawing.Point(424, 413);
            this.dtime_birthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtime_birthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtime_birthDate.Name = "dtime_birthDate";
            this.dtime_birthDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtime_birthDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_birthDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtime_birthDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtime_birthDate.Size = new System.Drawing.Size(224, 34);
            this.dtime_birthDate.TabIndex = 19;
            this.dtime_birthDate.Text = "jeudi 9 avril 2020";
            this.dtime_birthDate.Value = new System.DateTime(2020, 4, 9, 15, 33, 41, 680);
            // 
            // lbl_birthDate
            // 
            this.lbl_birthDate.AutoSize = true;
            this.lbl_birthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthDate.Location = new System.Drawing.Point(393, 385);
            this.lbl_birthDate.Name = "lbl_birthDate";
            this.lbl_birthDate.Size = new System.Drawing.Size(293, 25);
            this.lbl_birthDate.TabIndex = 20;
            this.lbl_birthDate.Text = "Date de naissance de l\'utilisateur";
            // 
            // cbox_role
            // 
            this.cbox_role.BackColor = System.Drawing.Color.Transparent;
            this.cbox_role.BaseColor = System.Drawing.Color.White;
            this.cbox_role.BorderColor = System.Drawing.Color.Silver;
            this.cbox_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_role.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_role.ForeColor = System.Drawing.Color.Black;
            this.cbox_role.FormattingEnabled = true;
            this.cbox_role.Location = new System.Drawing.Point(424, 495);
            this.cbox_role.Name = "cbox_role";
            this.cbox_role.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(212)))), ((int)(((byte)(253)))));
            this.cbox_role.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_role.Size = new System.Drawing.Size(227, 26);
            this.cbox_role.TabIndex = 21;
            this.cbox_role.Click += new System.EventHandler(this.cbox_role_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(448, 467);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(176, 25);
            this.lbl_role.TabIndex = 22;
            this.lbl_role.Text = "Role de l\'utilisateur";
            // 
            // uc_CreateUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.cbox_role);
            this.Controls.Add(this.lbl_birthDate);
            this.Controls.Add(this.dtime_birthDate);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_send_to_database);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.tbox_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tbox_firstname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.tbox_lastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.btn_back_to_AllUsers);
            this.Name = "uc_CreateUpdateUser";
            this.Size = new System.Drawing.Size(1140, 737);
            this.Load += new System.EventHandler(this.uc_CreateUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_back_to_AllUsers;
        private Guna.UI.WinForms.GunaLabel lbl_lastname;
        private Guna.UI.WinForms.GunaLineTextBox tbox_lastname;
        private Guna.UI.WinForms.GunaLineTextBox tbox_firstname;
        private Guna.UI.WinForms.GunaLabel lbl_firstname;
        private Guna.UI.WinForms.GunaLineTextBox tbox_username;
        private Guna.UI.WinForms.GunaLabel lbl_username;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaTileButton btn_send_to_database;
        private Guna.UI.WinForms.GunaLineTextBox tbox_password;
        private Guna.UI.WinForms.GunaLabel lbl_password;
        private Guna.UI.WinForms.GunaDateTimePicker dtime_birthDate;
        private Guna.UI.WinForms.GunaLabel lbl_birthDate;
        private Guna.UI.WinForms.GunaComboBox cbox_role;
        private Guna.UI.WinForms.GunaLabel lbl_role;
    }
}
