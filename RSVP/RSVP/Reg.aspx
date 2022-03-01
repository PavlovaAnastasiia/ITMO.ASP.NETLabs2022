<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="RSVP.WebForm1" UnobtrusiveValidationMode="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <linkrel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Приглашаем на семинар</h1><p></p>
        </div>
        <div>
            <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
            <label>Ваше имя:</label><asp:TextBox ID="name"
                runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Заполните поле имени" ForeColor="#FF3300">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Ваш email:</label><asp:TextBox ID="email"
                runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="email" ErrorMessage="Заполните поле адреса" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="E-mail is not in a valid format" Display="Dynamic" ForeColor="Red"> Адрес введен неверно!!!</asp:RegularExpressionValidator>
        </div>
        <div>
            <label>Ваш телефон:</label><asp:TextBox ID="phone"
                runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phone" ErrorMessage="Заполните поле ввода телефона" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <label>Вы будете делать доклад?</label><asp:CheckBox ID="CheckBoxYN"
                runat="server"/>
        </div>
        <div>
            <button type="submit">Отправить ответ на приглашение
                RSVP</button>
                </div>
    </form>
</body>
</html>
