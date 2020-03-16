
using System;

namespace EMR.Data.Models
{
    public partial class CD_OperationRecord
    {
        /// <summary>
        /// ����ʽ ����     450
        /// </summary>
        public string AnesthesiaWayName { get; set; }

        /// <summary>
        /// �������� ����     170
        /// </summary>
        public string OperationLevelName { get; set; }

        /// <summary>
        /// �����п����ϵȼ� ����     343
        /// </summary>
        public string HealingLevelName { get; set; }

        /// <summary>
        /// �����пڷּ� ����       238
        /// </summary>
        public string IncisionLevelName { get; set; }

        /// <summary>
        /// �������� ����     802
        /// </summary>
        public string OperationTypeName { get; set; }

        /// <summary>
        /// ������� ����     797
        /// </summary>
        public string OperationCategoryName { get; set; }
    }
}