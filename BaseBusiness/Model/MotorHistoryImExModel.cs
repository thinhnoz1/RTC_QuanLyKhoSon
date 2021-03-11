
using System;
namespace BMS.Model
{
	public class MotorHistoryImExModel : BaseModel
	{
		private int id;
		private int partID;
		private string partCode;
		private DateTime? dateImEx;
		private string workerCode;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
	
		public int PartID
		{
			get { return partID; }
			set { partID = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
		public DateTime? DateImEx
		{
			get { return dateImEx; }
			set { dateImEx = value; }
		}
	
		public string WorkerCode
		{
			get { return workerCode; }
			set { workerCode = value; }
		}
	
	}
}
	