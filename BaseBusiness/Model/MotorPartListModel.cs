
using System;
namespace BMS.Model
{
	public class MotorPartListModel : BaseModel
	{
		private int id;
		private string partCode;
		private int storageID;
		private string storageCode;
		private int quantity;
		private string description;
		private DateTime? createdDate;
		private DateTime? modifiedDate;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
		public int StorageID
		{
			get { return storageID; }
			set { storageID = value; }
		}
	
		public string StorageCode
		{
			get { return storageCode; }
			set { storageCode = value; }
		}
	
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
		public DateTime? CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}
	
		public DateTime? ModifiedDate
		{
			get { return modifiedDate; }
			set { modifiedDate = value; }
		}
	
	}
}
	