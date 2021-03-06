﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
//using MediaPortal.Profile;
//using MediaPortal.GUI.Library;
using System.Threading;
using System.Reflection;
//using MediaPortal.Configuration;
using System.Diagnostics;
using System.IO;
using MediaPortal.ProcessPlugins.Auto3D.UPnP;

namespace MediaPortal.ProcessPlugins.Auto3D.Devices
{
  public abstract class Auto3DUPnPBaseDevice : Auto3DBaseDevice, IAuto3DUPnPServiceCallBack
  {
    UPnPService _uPnPService = null;

    public Auto3DUPnPBaseDevice() : base()
    {
    }

    public UPnPService UPnPService
    {
      get { return _uPnPService; }
    }

    public abstract String UPnPServiceName
    {
      get;
    }

    public abstract String UPnPManufacturer
    {
      get;
    }

    public virtual void ServiceAdded(UPnPService service)
    {
      _uPnPService = service;
      ((IAuto3DUPnPSetup)GetSetupControl()).ServiceAdded(service);
    }

    public virtual void ServiceRemoved(UPnPService service)
    {
      ((IAuto3DUPnPSetup)GetSetupControl()).ServiceRemoved(service);
      _uPnPService = null;
    }
  }
}
