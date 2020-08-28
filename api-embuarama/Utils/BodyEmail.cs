using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_embuarama.Utils
{
    public class BodyEmail
    {
        public string FORGOT_PASSWORD = "<head>" +
            "<meta charset='UTF-8'>" +
            "<meta content='width=device-width, initial-scale=1' name='viewport'>" +
            "<meta name = 'x-apple-disable-message-reformatting'>" +
            "<meta http-equiv='X-UA-Compatible' content='IE=edge'>" +
            "<meta content = 'telephone=no' name='format-detection'>" +
            "<title> Novo e-mail</title>" +
            "<link href = 'https://fonts.googleapis.com/css?family=Open+Sans:400,400i,700,700i' rel='stylesheet'>" +
            "<style type='text/css' >" +
            "@media only screen and (max-width:600px) {p, ul li, ol li, a { font-size:16px!important; line-height:150%!important } h1 { font-size:30px!important; text-align:center; line-height:120% } h2 { font-size:26px!important; text-align:center; line-height:120% } h3 { font-size:20px!important; text-align:center; line-height:120% } h1 a { font-size:30px!important } h2 a { font-size:26px!important } h3 a { font-size:20px!important } .es-menu td a { font-size:16px!important } .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a { font-size:16px!important } .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a { font-size:16px!important } .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a { font-size:12px!important } *[class='gmail-fix'] { display:none!important } .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 { text-align:center!important } .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 { text-align:right!important } .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 { text-align:left!important } .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img { display:inline!important } .es-button-border { display:block!important } a.es-button { font-size:20px!important; display:block!important; border-left-width:0px!important; border-right-width:0px!important } .es-btn-fw { border-width:10px 0px!important; text-align:center!important } .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right { width:100%!important } .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header { width:100%!important; max-width:600px!important } .es-adapt-td { display:block!important; width:100%!important } .adapt-img { width:100%!important; height:auto!important } .es-m-p0 { padding:0px!important } .es-m-p0r { padding-right:0px!important } .es-m-p0l { padding-left:0px!important } .es-m-p0t { padding-top:0px!important } .es-m-p0b { padding-bottom:0!important } .es-m-p20b { padding-bottom:20px!important } .es-mobile-hidden, .es-hidden { display:none!important } tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden { width:auto!important; overflow:visible!important; float:none!important; max-height:inherit!important; line-height:inherit!important } tr.es-desk-hidden { display:table-row!important } table.es-desk-hidden { display:table!important } td.es-desk-menu-hidden { display:table-cell!important } table.es-table-not-adapt, .esd-block-html table { width:auto!important } table.es-social { display:inline-block!important } table.es-social td { display:inline-block!important } }" +
            "#outlook a { padding:0;}" +
            ".ExternalClass {width:100%;}" +
            ".ExternalClass,.ExternalClass p,.ExternalClass span,.ExternalClass font,.ExternalClass td,.ExternalClass div {	line-height:100%;}" +
            ".es-button {mso-style-priority:100!important;text-decoration:none!important;}" +
            "a[x-apple-data-detectors] {	color:inherit!important;	text-decoration:none!important;	font-size:inherit!important;	font-family:inherit!important;	font-weight:inherit!important;	line-height:inherit!important;}.es-desk-hidden {	display:none;	float:left;	overflow:hidden;	width:0;	max-height:0;	line-height:0;	mso-hide:all;}" +
            "</style>" +
            "</head>" +
            "<body style='width:100%;font-family:arial, 'helvetica neue', helvetica, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>"+
            "<div class='es-wrapper-color' style='background-color:#F6F6F6'>"+
            "<table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'> "+
            "<tr style='border-collapse:collapse'>"+
            "<td valign='top' style='padding:0;Margin:0'>"+
            "<table class='es-header' cellspacing='0' cellpadding='0' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>" + 
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='center' style='padding:0;Margin:0'>"+ 
            "<table class='es-header-body' cellspacing='0' cellpadding='0' bgcolor='#ffffff' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px'>"+
            "<tr style = 'border-collapse:collapse' >"+
            "<td style='Margin:0;padding-bottom:15px;padding-top:20px;padding-left:20px;padding-right:20px;background-color:#EDCD1F' bgcolor='#EDCD1F' align='left'>" +
            "<table width = '100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>" + 
            "<tr style = 'border-collapse:collapse' >"+
            "<td valign='top' align='center' style='padding:0;Margin:0;width:560px'>" + 
            "<table style = 'mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;border-left:2px dashed #FFFFFF;border-right:2px dashed #FFFFFF;border-top:2px dashed #FFFFFF;border-bottom:2px dashed #FFFFFF;background-position:left top' width='100%' cellspacing='0' cellpadding='0' role='presentation'>"+ 
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='center' style='padding:0;Margin:0;font-size:0px'><img class='adapt-img' src='https://iynkiu.stripocdn.email/content/guids/CABINET_d50d0edfd69c06e62718065e2bc02877/images/24501598567357847.png' alt style = 'display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' ></ td >" + 
            "</tr >" +
            "<tr style='border-collapse:collapse'>" + 
            "<td align='center' style='padding:0;Margin:0;padding-top:15px;padding-bottom:15px'><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:25px;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:38px;color:#0E0E0E'><br></p><h1 style = 'Margin:0;line-height:54px;mso-line-height-rule:exactly;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;font-size:36px;font-style:normal;font-weight:normal;color:#0E0E0E'><strong>EMBUARAMA</strong></h1><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:25px;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:38px;color:#0E0E0E'>CONSULTORIA</p><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:14px;font-family:'open sans', 'helvetica neue', helvetica, arial, sans-serif;line-height:21px;color:#0E0E0E'><br></p></td> "+
            "</tr>" + 
            "</table></td>" +
            "</tr>" +
            "</table></td>" + 
            "</tr>" + 
            "</table></td>" + 
            "</tr>" +
            "</table> " +
            "<table class='es-footer' cellspacing='0' cellpadding='0' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>"+ 
            "<tr style='border-collapse:collapse'>"+ 
            "<td align = 'center' style='padding:0;Margin:0'>"+ 
            "<table class='es-footer-body' cellspacing='0' cellpadding='0' bgcolor='#ffffff' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px'> "+
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='left' style='Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px'>"+ 
            "<table class='es-left' cellspacing='0' cellpadding='0' align='left' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:left'> "+
            "<tr style = 'border-collapse:collapse' >"+
            "<td class='es-m-p20b' align='left' style='padding:0;Margin:0;width:270px'>"+
            "<table width = '100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>"+ 
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='center' style='padding:0;Margin:0;display:none'></td>"+
            "</tr>"+ 
            "</table></td>"+ 
            "</tr>"+ 
            "</table>"+ 
            "<table class='es-right' cellspacing='0' cellpadding='0' align='right' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:right'>"+ 
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='left' style='padding:0;Margin:0;width:270px'>"+ 
            "<table width = '100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>"+ 
            "<tr style = 'border-collapse:collapse' >"+
            "<td align='center' style='padding:0;Margin:0;display:none'></td>"+ 
            "</tr>"+ 
            "</table></td>"+ 
            "</tr>"+ 
            "</table>"+ 
			"</td>" +
            "</tr>" +
            "</table></td>"+ 
            "</tr>"+ 
            "</table></td>"+ 
            "</tr>"+ 
            "</table>"+ 
            "</div>" +
            "<table class='es-content' cellspacing='0' cellpadding='0' align='center'>" +
            "<tr>" + 
            "<td align = 'center'>" +
            "<table class='es-content-body' width='600' cellspacing='0' cellpadding='0' bgcolor='#ffffff' align='center'>" + 
            "<tr>"+ 
            "<td class='es-p20t es-p20r es-p20l' align='left'>" +
            "<table width = '100%' cellspacing='0' cellpadding='0'>" +
            "<tr>" +
            "<td width = '560' valign='top' align='center'>" +
            "<table width = '100%' cellspacing='0' cellpadding='0' role='presentation'>" +
            "<tr>" +
            "<td align = 'left' ><p> &nbsp;<strong>Prezado usuário</strong>,<br>&nbsp; Esqueceu sua senha?<br><br>&nbsp; &nbsp;Para entrar no aplicativo utilize o código abaixo e modifique sua senha no link de configurações:<br><br>Código: <strong>{TOKEN}<br></strong><br> Caso não tenha pedido a troca de senha, ignorar este e-mail.<br> Atenciosamente, Suporte Embuaram Consultoria. <br><br><strong>O.B.S.: E-mail automatico, por favor não responder.</strong><span data-cke-bookmark='1' style='display: none'>&nbsp;</span></p></td>" + 
            "</tr>" +
            "</table></td>"  +
            "</tr>" +  
            "</table></td>"+
            "</tr>" + 
            "</table></td>" + 
            "</tr>"+ 
            "</table>"+ 
            "</body>" +
            "</html>";
    }
}