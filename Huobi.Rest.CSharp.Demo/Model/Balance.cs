using Newtonsoft.Json;
using System;

namespace Huobi.Rest.CSharp.Demo.Model
{
    public class Balance
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public Array List { get; set; }
    }
}
