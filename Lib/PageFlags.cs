﻿/****************************************************************************
 * NVorbis                                                                  *
 * Copyright (C) 2012, Andrew Ward <afward@gmail.com>                       *
 *                                                                          *
 * See COPYING for license terms (Ms-PL).                                   *
 *                                                                          *
 ***************************************************************************/
using System;

namespace NVorbis
{
    [Flags]
    enum PageFlags
    {
        None = 0,
        FreshPacket = 1,
        BeginningOfStream = 2,
        EndOfStream = 4,
    }
}
