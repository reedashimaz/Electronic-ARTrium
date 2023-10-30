import socket

#IP address and port of Unity program
unity_ip = '127.0.0.1'
unity_port = 800

#Creating UDP Socket
with socket.socket(socket.AF_INET, socket.SOCK_DGRAM) as sock:
    #AF-NET -> Address Family - Internet i.e., we are working with IPv4 addresses
    #SOCK_DGRAM -> specifies that we are creating a Datagram socket

    message = b'ChangeColor' #Message to send to Unity
    sock.sendto(message,(unity_ip, unity_port))

    print("Message sent to Unity. Background color may have changed.")
