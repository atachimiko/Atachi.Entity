using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atachi.Entity
{
	/// <summary>
	///     マスターデータ
	/// </summary>
	public interface IEntityMaster
	{
		DateTime ModifiedOn { get; set; }
	}
}
