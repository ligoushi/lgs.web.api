using lgs.web.api.IServices.BASE;
using lgs.web.api.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lgs.web.api.IServices
{
    /// <summary>
    /// RoleModulePermissionServices
    /// </summary>	
    public interface IRoleModulePermissionServices :IBaseServices<RoleModulePermission>
	{

        Task<List<RoleModulePermission>> GetRoleModule();
        Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
        Task<List<RoleModulePermission>> GetRMPMaps();
        /// <summary>
        /// �������²˵���ӿڵĹ�ϵ
        /// </summary>
        /// <param name="permissionId">�˵�����</param>
        /// <param name="moduleId">�ӿ�����</param>
        /// <returns></returns>
        Task UpdateModuleId(int permissionId, int moduleId);
    }
}