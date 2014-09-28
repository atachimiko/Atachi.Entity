using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atachi.Entity
{
	public interface IEntityValidation
	{
		bool Validation(IEntityData entity, params object[] args);
	}
}
