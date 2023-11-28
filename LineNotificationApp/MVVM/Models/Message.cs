using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LineNotificationApp;
public class Message
{
	private int _stickerPackageId;

    [JsonPropertyOrder(0)]
    public int stickerPackageId
    {
		get { return _stickerPackageId; }
		set { _stickerPackageId = value; }
	}
	private int _stickerId;

    [JsonPropertyOrder(1)]
    public int stickerId
    {
		get { return _stickerId; }
		set { _stickerId = value; }
	}

}
