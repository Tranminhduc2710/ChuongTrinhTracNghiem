﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtTracNghiem
{
    public interface ICauHoiList
    {
        List<string> DanhSachCauHoi { get; set; }
        void XoaCauHoi(KiemTraDieuKien dieuKien);
    }
}
