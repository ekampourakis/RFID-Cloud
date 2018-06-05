"""
Routes and views for the flask application.
"""

from datetime import datetime
from flask import render_template, request
from RFIDSharing_Server import app

@app.route('/')
@app.route('/home')
def home():
    """Renders the home page."""
    return render_template(
        'index.html',
        title='Home Page',
        year=datetime.now().year,
    )

@app.route('/contact')
def contact():
    """Renders the contact page."""
    return render_template(
        'contact.html',
        title='Contact',
        year=datetime.now().year,
        message='Your contact page.'
    )

@app.route('/about')
def about():
    """Renders the about page."""
    return render_template(
        'about.html',
        title='About',
        year=datetime.now().year,
        message='Your application description page.'
    )

@app.route('/register')
def register():
    """Renders the about page."""
    page = request.args.get('page', default = "wut", type = str)
    filter = request.args.get('filter', default = '*', type = str)
    return render_template(
        'return.html',
        data=page
    )

@app.route('/get')
def get():
    """Renders the about page."""
    return render_template(
        'about.html',
        title='Get',
        year=datetime.now().year,
        message='Get function.'
    )