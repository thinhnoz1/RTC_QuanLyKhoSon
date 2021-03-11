
using System;
namespace BMS.Model
{
	public class MotorStorageListModel : BaseModel
	{
		private int id;
		private string storageCode;
		private string storageName;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
	
		public string StorageCode
		{
			get { return storageCode; }
			set { storageCode = value; }
		}
	
		public string StorageName
		{
			get { return storageName; }
			set { storageName = value; }
		}
	
	}
}
	