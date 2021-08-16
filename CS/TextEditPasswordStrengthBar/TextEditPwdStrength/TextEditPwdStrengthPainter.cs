using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace TextEditPasswordStrengthBar
{
    class TextEditPwdStrengthPainter : TextEditPainter
    {
        public TextEditPwdStrengthPainter() : base() { }
        
        protected override void DrawContent(ControlGraphicsInfoArgs info) {
            base.DrawContent(info);
            this.DrawLine(info);
        }

        void DrawLine(ControlGraphicsInfoArgs info)
        {
            TextEditViewInfo vi = info.ViewInfo as TextEditViewInfo;
            Rectangle r = vi.ClientRect;
            r.Height = 3;

            r.Y = vi.ClientRect.Height - r.Height;
            Brush brush = Brushes.Green;

            switch (this.GetPasswordStrength(vi.EditValue, vi.ClientRect))
            {
                case 0:
                    if (vi.EditValue == null || vi.EditValue.ToString().Length == 0)
                        r.Width = 0;
                    else
                        r.Width = r.Width / 3;
                    brush = Brushes.Red;
                    break;
                case 1:
                    r.Width = r.Width * 2 / 3;
                    brush = Brushes.Orange;
                    break;
            }
            info.Paint.FillRectangle(info.Graphics, brush, r);
        }

        int GetPasswordStrength(object pwd, Rectangle contentRectangle)
        {
            int passwordStrength = 0, passwordPoints = 0;
            if (pwd == null) return passwordStrength;

            string password = pwd.ToString();

            // Simple algorithm of password strength calculation
            Regex rx;
            // If password is longer than 6 symbols than add 1 point
            if (password.Length > 6)
                passwordPoints++;
            // If password has both lower and upper case characters than add 1 point
            rx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])");
            if (rx.Match(password).Success)
                passwordPoints++;
            // Add 1 point if password contains at least one digit
            rx = new Regex(@"[0-9]");
            if (rx.Match(password).Success)
                passwordPoints++;
            // Add 1 point in case if password contains at least one special char
            rx = new Regex(@"\~|\@|\#|\$|\%|\^|\&|\*|\:|\;");
            if (rx.Match(password).Success)
                passwordPoints++;
            // Add 1 point if password is longer than 12 symbols
            if (password.Length > 12)
                passwordPoints++;

            if (passwordPoints > 3)
                passwordStrength = 2;
            else if (passwordPoints >= 2 && passwordPoints <= 3)
                passwordStrength = 1;

            return passwordStrength;
        }
    }
}
