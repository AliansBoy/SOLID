using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
	public class ReportBuilder
	{
	/// Сгенерировать отчет.
		/// <param name="reportType"> Тип отчета.</param>
		public void CreateReport(ReportType reportType)
		{
			switch (reportType)
			{
				case ReportType.excel:
					// Генерация отчета Excel.
					break;
				case ReportType.pdf:
					// Генерация отчета Pdf.
					break;
				case ReportType.xml:
					// Генерация отчета Xml.
					break;
			}
		}
	}
}
