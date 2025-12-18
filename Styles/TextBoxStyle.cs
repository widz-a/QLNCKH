using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TextBoxStyle {
    public static void Apply(TextBox txt, Panel border) {
        txt.BorderStyle = BorderStyle.None;
        txt.Font = new Font("Segoe UI", 10F);
        txt.BackColor = Color.White;

        border.BackColor = Color.FromArgb(209, 213, 219); // gray

        txt.Enter += (s, e) =>
            border.BackColor = Color.FromArgb(59, 130, 246);

        txt.Leave += (s, e) =>
            border.BackColor = Color.FromArgb(209, 213, 219);
    }
}
