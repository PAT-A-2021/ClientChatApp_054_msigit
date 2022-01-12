using System;
using System.ServiceModel;

namespace ServiceReference1
{
    internal class ServiceCallbackClient
    {
        private InstanceContext context;

        public ServiceCallbackClient(InstanceContext context)
        {
            this.context = context;
        }

        internal void kirimPesan(string pesan)
        {
            throw new NotImplementedException();
        }

        internal void gabung(string nama)
        {
            throw new NotImplementedException();
        }
    }
}