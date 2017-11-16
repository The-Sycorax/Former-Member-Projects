﻿/* CommandsInit.cs - initializes commands
 * Copyright (C) 2012 NoobOS
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
namespace NoobOS.Commands
{
	class CommandInit
	{
		public static void Init()
		{
			CommandManager.Register(new MakeDirectory());
			CommandManager.Register(new ListDirectories());
			CommandManager.Register(new ChangeDirectory());
			CommandManager.Register(new RemoveDirectory());
			CommandManager.Register(new CatCommand());
			CommandManager.Register(new TouchCommand());
			CommandManager.Register(new HelpCommand());
            //CommandManager.Register(new ExecCommand());
            //CommandManager.Register(new FileEditor());
		}
	}
}
