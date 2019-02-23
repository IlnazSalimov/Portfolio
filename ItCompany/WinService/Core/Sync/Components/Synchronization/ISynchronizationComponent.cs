﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Service.Core.Sync.Components
{
    public interface ISynchronizationComponent
    {
        /// <summary>
        /// Выполнить синхронизацию
        /// </summary>
        void Synchronize();
    }
}
