# Импорт библиотек для взаимодействия с ОС

import os
import platform
from operator import index

# Библиотеки для получения характеристик

import cpuinfo # pip install py-cpuinfo
import torch # pip install torch
import psutil # pip install psutil
import wmi # pip install WMI
from pyspectator.processor import Cpu # pip install pyspectator


from time import sleep


class RecordingOS:
    def __init__(self):
        pass

    def get_os_name_with_version(self):
        print("Операционная система: " + platform.platform())

    def get_username(self):
        print("Имя пользователя:" + os.getlogin())

    def info_processor(self):
        print("Процессор: " + cpuinfo.get_cpu_info()['brand_raw'])
    
    def time_for_unix_system(self):
        t = os.popen('uptime -p').read()[:-1] 
        print(t)

    def general_info(self):
        my_system = platform.uname()
        print(f"Система: {my_system.system}")
        print(f"Релиз системы: {my_system.release}")
        print(f"Имя ПК: {my_system.node}")
        print(f"Версия ОС: {my_system.version}")
        print(f"Архитектура процесса: {my_system.machine}")
        print(f"Процессор: {my_system.processor}")

    def CPU_info(self):
        print(os.cpu_count())

    def memory_info(self):
        print('Системная память:', psutil.virtual_memory())
        print('Системная память подкачки:', psutil.swap_memory())

    # Работает только для Windows
    def GPU_info(self):
        print(torch.cuda.get_device_name(0))

    def CPU_temp_now(self):
        cpu = Cpu(monitoring_latency=1)
        with cpu:
            for _ in range(8): # Сколько раз вывести инфу
                print(cpu.load)
                print(cpu.temperature)
                sleep(1.1)

if __name__ == '__main__':
    user_OS = RecordingOS()
    user_OS.get_os_name_with_version()
    user_OS.get_username()
    user_OS.info_processor()
    user_OS.general_info()
    user_OS.CPU_info()
    user_OS.memory_info()
    user_OS.CPU_temp_now()
