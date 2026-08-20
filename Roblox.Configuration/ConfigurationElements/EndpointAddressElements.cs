using System.Configuration;

namespace Roblox.Configuration
{
    public class EndpointAddressElements : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }
        protected override string ElementName
        {
            get { return "endpointAddress"; }
        }
        protected override ConfigurationPropertyCollection Properties
        {
            get { return new ConfigurationPropertyCollection(); }
        }
        public EndpointAddressElement this[int index]
        {
            get
            {
                return (EndpointAddressElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null) BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }
        new public EndpointAddressElement this[string name]
        {
            get { return (EndpointAddressElement)BaseGet(name); }
        }

        public void Add(EndpointAddressElement item) { BaseAdd(item); }
        public void Remove(EndpointAddressElement item) { BaseRemove(item); }
        public void RemoveAt(int index) { BaseRemoveAt(index); }
        protected override ConfigurationElement CreateNewElement() { return new EndpointAddressElement(); }
        protected override object GetElementKey(ConfigurationElement element) { return (element as EndpointAddressElement).EndpointConfigurationName; }
    }
}
