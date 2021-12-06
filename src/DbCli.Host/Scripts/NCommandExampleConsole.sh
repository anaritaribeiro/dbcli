# Autostart on raspberry
# /home/pi/.config/autostart/NCommandExampleConsole.desktop
# Exec=/usr/bin/lxterminal -e "/bin/bash -c 'cd /home/pi/[deployment-folder]; chmod 777 NCommandExampleConsole.sh; ./NCommandExampleConsole.sh; read -n 1 -s'"
# Carrige return on linux: VSCode bottom right   or   sed -i 's/\r//g' NCommandExampleConsole.sh

echo "NCommandExampleConsole called"
chmod 777 ./NCommandExampleConsole
./NCommandExampleConsole