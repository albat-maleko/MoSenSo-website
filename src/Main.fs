module Main

open Browser.Dom

let page =
    """
    <header id="header">
      <nav class="container">
        <div class="logo"><i class="fa-solid fa-chart-pie"></i> MoSenSo<span>Digital<span>Marketing</span></div>
        <ul class="nav-links">
          <li><a href="#home">Home</a></li>
          <li><a href="#about">About</a></li>
          <li><a href="#services">Services</a></li>
          <li><a href="#contact">Contact</a></li>
        </ul>
        <div class="menu-toggle"><i class="fa-solid fa-bars"></i></div>
      </nav>
    </header>

    <section id="home" class="box-hero">
      <div class="box-hero-content container">
        <h1>We Drive <span class="highlight">Digital Growth</span> for Your Business</h1>
        <p>Transform your online presence with data-driven marketing strategies, SEO, and engaging social media campaigns designed to convert.</p>
        <div class="hero-buttons">
          <a href="#contact" class="btn btn-primary">Get a Free Audit</a>
          <a href="#services" class="btn btn-secondary">Explore Services</a>
        </div>
      </div>
    </section>

    <section id="about" class="box-about container">
      <div class="about-text">
        <h2>Who is MoSenSo Digital Marketing?</h2>
        <div class="divider"></div>
        <p>We are a forward-thinking digital marketing agency dedicated to helping brands navigate the digital landscape.</p>
        <ul class="about-list">
          <li><i class="fa-solid fa-check-circle"></i> Data-Driven Strategies</li>
          <li><i class="fa-solid fa-check-circle"></i> Transparent Reporting</li>
          <li><i class="fa-solid fa-check-circle"></i> ROI-Focused Campaigns</li>
        </ul>
      </div>
      <div class="about-image">
        <img src="https://images.unsplash.com/photo-1552664730-d307ca884978?auto=format&fit=crop&w=800&q=80" alt="Team collaborating">
      </div>
    </section>

    <section id="services" class="services-section">
      <div class="container text-center">
        <h2>Our Core Services</h2>
        <div class="divider center"></div>
        <p class="section-subtitle">Comprehensive solutions to scale your business online.</p>

        <div class="services-grid">
          <div class="service-card">
            <div class="icon"><i class="fa-solid fa-magnifying-glass-chart"></i></div>
            <h3>SEO Optimization</h3>
            <p>Dominate search engine rankings and drive organic traffic to your website.</p>
          </div>
          <div class="service-card">
            <div class="icon"><i class="fa-solid fa-hashtag"></i></div>
            <h3>Social Media Marketing</h3>
            <p>Build a loyal community and boost brand awareness.</p>
          </div>
          <div class="service-card">
            <div class="icon"><i class="fa-solid fa-pen-nib"></i></div>
            <h3>Content Strategy</h3>
            <p>Engage your audience with compelling articles and graphics.</p>
          </div>
          <div class="service-card">
            <div class="icon"><i class="fa-solid fa-bullhorn"></i></div>
            <h3>PPC Advertising</h3>
            <p>Maximize your ROI with targeted campaigns.</p>
          </div>
        </div>
      </div>
    </section>

    <section id="contact" class="contact container">
      <div class="contact-info">
        <h2>Let's Talk Growth</h2>
        <div class="divider"></div>
        <p>Ready to take your business to the next level? Reach out to us today.</p>

        <div class="info-item">
          <i class="fa-solid fa-envelope"></i>
          <span>hello@mosensodigitalmarketing.com</span>
        </div>
        <div class="info-item">
          <i class="fa-solid fa-phone"></i>
          <span>+255 746 861 651</span>
        </div>
        <div class="info-item">
          <i class="fa-solid fa-location-dot"></i>
          <span>Arusha, Tanzania</span>
        </div>
      </div>

      <form class="contact-form" action="https://formspree.io/f/mkoladgz" method="POST">
        <input type="text" name="name" placeholder="Your Name" required>
        <input type="email" name="email" placeholder="Your Email" required>
        <select name="service">
          <option value="">Interested Service...</option>
          <option value="seo">SEO</option>
          <option value="social">Social Media</option>
          <option value="ads">Paid Ads</option>
        </select>
        <textarea name="message" rows="5" placeholder="Tell us about your project" required></textarea>
        <button type="submit" class="btn btn-primary">Send Message</button>
      </form>
    </section>

    <footer>
      <div class="container footer-content">
        <div class="footer-logo">
          <i class="fa-solid fa-chart-pie"></i> MoSenSo<span>Digital<span>Marketing</span>
        </div>
        <div class="social-links">
          <a href="#"><i class="fa-brands fa-linkedin"></i></a>
          <a href="#"><i class="fa-brands fa-twitter"></i></a>
          <a href="https://www.instagram.com/mosenso_digital_marketing?igsh=YXdjMm10NzJsZDB0"><i class="fa-brands fa-instagram"></i></a>
          <a href="#"><i class="fa-brands fa-facebook"></i></a>
        </div>
      </div>
      <div class="footer-bottom">
        <p>&copy; 2026 MoSenSo Digital Marketing. All rights reserved.</p>
      </div>
    </footer>
    """

let render () =
    let root = document.getElementById "app"
    if not (isNull root) then
        root.innerHTML <- page

        let menu = document.querySelector ".menu-toggle"
        let nav = document.querySelector ".nav-links"

        if not (isNull menu) && not (isNull nav) then
            menu.addEventListener("click", fun _ ->
                nav.classList.toggle("open") |> ignore
            )

            let links = nav.querySelectorAll "a"
            for i = 0 to links.length - 1 do
                links.item(i).addEventListener("click", fun _ ->
                    nav.classList.remove("open") |> ignore
                )

render ()
