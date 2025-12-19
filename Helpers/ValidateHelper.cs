using System.Text.RegularExpressions;

public static class ValidateHelper {
    public static bool Required(TextBox txt, string fieldName) {
        if (string.IsNullOrWhiteSpace(txt.Text)) {
            MessageBox.Show($"{fieldName} không được để trống.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt.Focus();
            return false;
        }
        return true;
    }

    public static bool SafeText(TextBox txt, string fieldName) {
        string pattern = @"['"";\-]";
        if (Regex.IsMatch(txt.Text, pattern)) {
            MessageBox.Show($"{fieldName} chứa ký tự không hợp lệ.",
                "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt.Focus();
            return false;
        }
        return true;
    }

    public static bool RequiredSafe(TextBox txt, string fieldName) {
        return Required(txt, fieldName) && SafeText(txt, fieldName);
    }
    public static bool Required(ComboBox cbo, string fieldName) {
        if (cbo.SelectedIndex < 0) {
            MessageBox.Show($"Vui lòng chọn {fieldName}.",
                "Thiếu thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            cbo.Focus();
            return false;
        }
        return true;
    }

    public static bool RequiredDouble(TextBox txt, string fieldName) {
        if (!double.TryParse(txt.Text, out _)) {
            MessageBox.Show($"{fieldName} phải là số hợp lệ.",
                "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt.Focus();
            return false;
        }
        return true;
    }

    public static bool Phone(TextBox txt) {
        if (!Regex.IsMatch(txt.Text, @"^\d{9,11}$")) {
            MessageBox.Show("Số điện thoại không hợp lệ.",
                "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txt.Focus();
            return false;
        }
        return true;
    }
}