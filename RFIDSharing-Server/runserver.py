"""
This script runs the RFIDSharing_Server application using a development server.
"""

from os import environ
from RFIDSharing_Server import app

if __name__ == '__main__':
    HOST = environ.get('SERVER_HOST', 'localhost')
    try:
        PORT = int(environ.get('SERVER_PORT', '5555'))
    except ValueError:
        PORT = 5555
    app.run(HOST, PORT)
