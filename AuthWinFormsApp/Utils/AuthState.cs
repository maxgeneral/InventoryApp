using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace AuthWinFormsApp.Utils
{
    public enum AuthRole
    {
        /// <summary>
        /// Роль сотрудника, проводящего процедуру инвентаризации
        /// </summary>
        InventoryPerson,
        /// <summary>
        /// Роль материально-ответственного лица
        /// </summary>
        ResponsiblePerson
    }

    public class AuthState
    {
        private static readonly AuthState authState = new AuthState();

        private AuthState()
        {
            ;
        }

        public bool IsAuth { get; set; } = false;
        public AuthRole Role { get; set; } = AuthRole.InventoryPerson;

        public static AuthState This() => authState;

    }
}
