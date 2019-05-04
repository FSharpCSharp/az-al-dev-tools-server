﻿using AnZwDev.ALTools;
using AnZwDev.VSCodeLangServer.Protocol.MessageProtocol;
using AZALDevToolsServer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZALDevToolsServer.Handlers
{
    public class CloseSymbolsLibraryNotificationHandler : BaseALNotificationHandler<CloseSymbolsLibraryRequest>
    {

        public CloseSymbolsLibraryNotificationHandler(ALDevToolsServer alDevToolsServer) : base(alDevToolsServer, "al/closesymbolslibrary")
        {
        }

        public override async Task HandleNotification(CloseSymbolsLibraryRequest parameters, NotificationContext context)
        {
            this.Server.SymbolsLibraries.RemoveLibrary(parameters.libraryId);
        }
    }
}
