using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm.DescargarArchivos
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void DPF_Click(object sender, EventArgs e)
		{
			//archivo desde una ruta externa
			string UrlString = "https://www.fing.edu.uy/tecnoinf/mvd/cursos/adminf/material/ADI-usuarios-y-grupos-en-linux.pdf";
			string fileName = System.IO.Path.GetFileName(UrlString);
			string descFilePathAndName = fileName;
			try
			{
				WebRequest myre = WebRequest.Create(UrlString);
			}
			catch
			{
				//return false;
			}
			try
			{
				byte[] fileData;
				using (WebClient client = new WebClient())
				{
					fileData = client.DownloadData(UrlString);
				}

				Response.ContentType = "Application/pdf";
				Response.AddHeader("Content-Disposition", "attachment; filename=" + "ADI-usuarios-y-grupos-en-linux.pdf");
				Response.OutputStream.Write(fileData, 0, fileData.Length);
				Response.Flush();
			}
			catch (Exception ex)
			{
				throw new Exception("download field", ex);
			}
		}

		protected void Imagen_Click(object sender, EventArgs e)
		{
			//archivo desde una ruta externa
			string UrlString = "https://www.confiamed.com/web/wp-content/uploads/2017/06/pymes.png";
			string fileName = System.IO.Path.GetFileName(UrlString);
			string descFilePathAndName = fileName;
			try
			{
				WebRequest myre = WebRequest.Create(UrlString);
			}
			catch
			{
				//return false;
			}
			try
			{
				byte[] fileData;
				using (WebClient client = new WebClient())
				{
					fileData = client.DownloadData(UrlString);
				}

				Response.ContentType = "Image/png";
				Response.AddHeader("Content-Disposition", "attachment; filename=" + "pymes.png");
				Response.OutputStream.Write(fileData, 0, fileData.Length);
				Response.Flush();
			}
			catch (Exception ex)
			{
				throw new Exception("download field", ex);
			}
		}
	}
}