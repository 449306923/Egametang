﻿using System;
using UnityEngine;

namespace Model
{
	public static class ConfigHelper
	{
		public static string GetText(string key)
		{
			try
			{
				string configStr = ((GameObject)Resources.Load("Config")).Get<TextAsset>(key).text;
				return configStr;
			}
			catch (Exception)
			{
				throw new GameException($"load config file fail, key: {key}");
			}
		}
	}
}
