using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    class ReportBuilder
    {
		public class BaseReportBuilder
		{
			public virtual void CreateReport()
			{
				// Базовая реализация генерации отчетов.
			}
		}

		/// Класс для генерации отчетов в excel.
		public class ExcelReportsBuilder : BaseReportBuilder
		{
			public override void CreateReport()
			{
			}
		}

		/// Класс для генерации отчетов в pdf.
		public class PdfReportsBuilder : BaseReportBuilder
		{
			public override void CreateReport()
			{
			}
		}

		/// Класс для генерации отчетов в xml.
		public class XmlReportsBuilder : BaseReportBuilder
		{
			public override void CreateReport()
			{
			}
		}
	}
}
