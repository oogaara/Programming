import socket
import threading

url = input("URL:")

def portscan(url, port):
    s =socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.settimeout(5)

    try:
        conecta = s.connect_ex((url, port))
        if conecta == 0:
            print(f"{port} OPEN")
        s.close()
    except socket.error:
        pass
def scan(url, num_threads=30):
    threads = []
    for i in range(1, 65535):  
        thread = threading.Thread(target=portscan, args=(url, i))
        threads.append(thread)
        thread.start()

    for thread in threads:
        thread.join()

scan(url)    
