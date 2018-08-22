using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserSimplelistResponse.
    /// </summary>
    public class OapiUserSimplelistResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// hasMore
        /// </summary>
        [XmlElement("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// userid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

    }
}
