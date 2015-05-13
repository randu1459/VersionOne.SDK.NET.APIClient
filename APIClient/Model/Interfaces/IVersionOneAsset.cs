using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionOne.SDK.APIClient.Model.Interfaces
{
	public interface IVersionOneAsset
	{
		string AssetType { get; }
		string ID { get; }
	}
}
